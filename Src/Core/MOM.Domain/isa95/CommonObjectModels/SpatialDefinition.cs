namespace MOM.Domain.isa95.CommonObjectModels
{
    using Microsoft.EntityFrameworkCore;
    using System.Text.Json.Serialization;

    [Owned]
    public class SpatialDefinition
    {
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("format")]
        public string? Format { get; set; }

        [JsonPropertyName("SRID")]
        public string? SRID { get; set; }

        [JsonPropertyName("SRIDauthority")]
        public string? SRIDauthority { get; set; }
    }
}