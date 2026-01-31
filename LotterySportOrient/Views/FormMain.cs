using LotterySportOrient.Models;
using LotterySportOrient.Services;
using System.Runtime.CompilerServices;

namespace LotterySportOrient
{
    public partial class FormMain : Form
    {
        private Race _race;
        private List<Group> _allGroups;
        private List<Group> _groups;
        private List<Result> _results;
        private int count = 0;
        public FormMain(List<Race> races)
        {
            InitializeComponent();
            _race = races[0];
            _allGroups = _race.Groups;
            _groups = _allGroups;
            _results = _race.Results;

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

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (_groups.Count == 0)
            {
                MessageBox.Show("Нет выбранных групп");
                return;
            }

            if (count >= _groups.Count)
            {
                MessageBox.Show("Список закончился");
                return;
            }

            labelNumber.Text = _groups[count].Name;
            count++;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!radioButtonAllGroups.Checked)
            {
                _groups = FilterByCheckedGroup();
                _groups = Service.RandomizedList(_groups);
                count = 0;
            }
            else
            {

            }
        }

        private void checkedListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
