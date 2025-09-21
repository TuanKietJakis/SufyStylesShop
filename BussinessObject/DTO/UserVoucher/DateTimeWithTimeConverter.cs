using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.DTO.UserVoucher
{
    public class DateTimeWithTimeConverter : JsonConverter<DateTime?>
    {
        private static readonly string[] DateFormats = new string[]
        {
        "dd/MM/yyyy",
        "yyyy/MM/dd"
        };

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? dateString = reader.GetString();
            if (string.IsNullOrEmpty(dateString))
            {
                return null;
            }
            if (DateTime.TryParseExact(dateString, DateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            }
            if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime generalDate))
            {
                return new DateTime(generalDate.Year, generalDate.Month, generalDate.Day, 23, 59, 59);
            }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                string formattedDate = value.Value.ToString("dd/MM/yyyy");
                writer.WriteStringValue(formattedDate);
            }
        }
    }
}
