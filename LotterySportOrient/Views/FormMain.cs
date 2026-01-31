using LotterySportOrient.Models;
using LotterySportOrient.Services;

namespace LotterySportOrient
{
    public partial class FormMain : Form
    {
        private Race _race;
        private List<Group> _allGroups;
        private List<Group> _groups;
        private List<Result> _results;
        private List<Result> _allResults;
        private int count = 0;
        public FormMain(List<Race> races)
        {
            InitializeComponent();
            _race = races[0];
            _allGroups = _race.Groups;
            _allGroups.Reverse();
            _groups = _allGroups;

            _allResults = _race.Results;
            _results = _allResults;

            checkedListBoxGroups.Enabled = false;

            count = 0;

            FillGroupListBox();
            LoadData();
        }

        private void FillGroupListBox()
        {
            checkedListBoxGroups.Items.Clear();

            foreach (var group in _allGroups)
            {
                checkedListBoxGroups.Items.Add(group.Name);
            }
        }

        private void radioButtonRangeGroups_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxGroups.Enabled = true;
            LoadData();
        }

        private void radioButtonAllGroups_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBoxGroups.Enabled = false;
            LoadData();
        }

        private List<Group> FilterByCheckedGroup()
        {
            if (radioButtonAllGroups.Checked)
                return _allGroups;

            var selectedGroupNames = checkedListBoxGroups.CheckedItems
                .Cast<string>()
                .ToHashSet();

            if (selectedGroupNames.Count == 0)
                return _allGroups;

            return _allGroups
                .Where(g => selectedGroupNames.Contains(g.Name))
                .ToList();
        }

        private List<Result> FilterByGroup(List<Group> groups)
        {
            if (radioButtonAllGroups.Checked)
                return _allResults;

            var groupIds = groups
                .Select(g => g.Id)
                .ToHashSet();

            var personIds = _race.Persons
                .Where(p => groupIds.Contains(p.GroupId))
                .Select(p => p.Id)
                .ToHashSet();

            return _allResults
                .Where(r => personIds.Contains(r.PersonId))
                .ToList();
        }

        private List<Result> FilterByWins(List<Result> source)
        {
            if (!checkBoxOnlyWins.Checked)
                return source;

            return source
                .Where(r => r.Place >= 1 && r.Place <= 3)
                .ToList();
        }


        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (_results == null || _results.Count == 0)
            {
                MessageBox.Show("Нет результатов по выбранным условиям");
                return;
            }

            if (count >= _results.Count)
            {
                MessageBox.Show("Список закончился");
                return;
            }

            var current = _results[count];
            Result previous = count > 0 ? _results[count - 1] : null;

            // текущий
            var person = _race.Persons.FirstOrDefault(p => p.Id == current.PersonId);
            var group = _race.Groups.FirstOrDefault(g => g.Id == person?.GroupId);

            labelNumber.Text = current.Bib.ToString();
            labelName.Text = person?.Name ?? "-";
            labelSurname.Text = person?.Surname ?? "-";
            labelGroupName.Text = group?.Name ?? "-";

            string allPrevRes = "";

            // предыдущий
            if (previous != null)
            {
                var personPrev = _race.Persons.FirstOrDefault(p => p.Id == previous.PersonId);
                var groupPrev = _race.Groups.FirstOrDefault(g => g.Id == personPrev?.GroupId);

                allPrevRes = $"{previous.Bib} |  {personPrev?.Surname} {personPrev?.Name}  | {groupPrev?.Name}"; 

                listBoxStackResults.Items.Insert(0, allPrevRes);
            }
            else
            {
                allPrevRes = "";
                listBoxStackResults.Items.Insert(0, allPrevRes);

            }

            count++;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _groups = FilterByCheckedGroup();

            var results = FilterByGroup(_groups);
            results = FilterByWins(results);

            _results = Service.RandomizedList(results);
            count = 0;
        }


        private void checkedListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDeleteFilters_Click(object sender, EventArgs e)
        {
            radioButtonAllGroups.Checked = true;
            checkBoxOnlyWins.Checked = false;
            _results = _allResults;
            _groups = _allGroups;
        }
    }
}
