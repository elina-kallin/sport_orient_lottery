using LotterySportOrient.Models;
using LotterySportOrient.Services;

namespace LotterySportOrient.Views
{
    public partial class FormLoadFile : Form
    {
        public FormLoadFile()
        {
            InitializeComponent();
            openFileDialog.Filter = "json files(*.json)|*.json|All files(*.*)|*.*";
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string filePath = openFileDialog.FileName;

            List<Race> races = Service.LoadRacesFromFile(filePath);

            if(races.Count > 0)
            {
                var formMain = new FormMain(races);
                this.Hide();
                formMain.ShowDialog();
                this.Show();
            }
        }
    }
}
