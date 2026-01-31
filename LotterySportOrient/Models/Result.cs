using System.Text.Json.Serialization;

namespace LotterySportOrient.Models
{
    public class Result
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("person_id")]
        public string PersonId { get; set; }

        [JsonPropertyName("bib")]
        public int Bib { get; set; }

        [JsonPropertyName("place")]
        public int Place { get; set; }
    }
}
