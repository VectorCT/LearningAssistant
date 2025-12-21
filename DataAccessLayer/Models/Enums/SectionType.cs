using System.Text.Json.Serialization;

namespace DataAccessLayer.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SectionType
{
  Title,
  Subtitle,
  Paragraph,
  Image
}
