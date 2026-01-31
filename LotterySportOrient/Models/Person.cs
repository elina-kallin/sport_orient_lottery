using System.Text.Json.Serialization;

namespace LotterySportOrient.Models
{
    public class Person
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
