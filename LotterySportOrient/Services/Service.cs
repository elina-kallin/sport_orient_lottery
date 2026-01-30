using LotterySportOrient.Models;
using System.Text.Json;

namespace LotterySportOrient.Services
{
    public static class Service
    {
        public static List<Race> LoadRacesFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<Race>();

            try
            {
                var json = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                Root root = JsonSerializer.Deserialize<Root>(json, options);

                return root?.Races ?? new List<Race>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Race>();
            }
        }
    }
}
