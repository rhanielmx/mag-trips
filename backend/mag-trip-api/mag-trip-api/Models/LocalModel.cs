using System.Text.Json.Serialization;

namespace mag_trip_api.Models {
  public class LocalModel
  {
      [JsonPropertyName("name")]
      public string? Name { get; set; }

      [JsonPropertyName("country")]
      public string? Country { get; set; }

      [JsonPropertyName("lat")]
      public double? Lat { get; set; }

      [JsonPropertyName("lon")]
      public double? Lon { get; set; }

      [JsonPropertyName("population")]
      public int? Population { get; set; }

      [JsonPropertyName("timezone")]
      public string? Timezone { get; set; }

      [JsonPropertyName("status")]
      public string? Status { get; set; }
  }
}