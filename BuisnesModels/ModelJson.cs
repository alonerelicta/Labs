
using System.Text.Json.Serialization;

namespace LabaInformationTechologics.BuisnesModels
{
    public class ModelJson
    {
        
        [JsonPropertyName("name")]
        public String name { get; set; }
        [JsonPropertyName("founder")]
        public String founder { get; set; }
        [JsonPropertyName("founded")]
        public int founded { get; set; }
        [JsonPropertyName("summary")]
        public String summary { get; set; }
    }
}
