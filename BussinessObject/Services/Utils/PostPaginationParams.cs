using BussinessObject.Utils;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO
{
    public class PostPaginationParams : PaginationParams
    {

        [SwaggerParameter(Description = "The title keyword to filter posts by title. This is an optional parameter.")]
        public string? TitleKeyword { get; set; }


        [JsonConverter(typeof(DateFormatConverter))]
        [SwaggerParameter(Description = "The creation date to filter posts by. The format should be 'dd/MM/yyyy' or 'dd-MM-yyyy'. Optional parameter.")]
        public string? CreateDate { get; set; }


        [SwaggerParameter(Description = "Include deleted comments in the result. Optional parameter. Default is false.")]
        public bool? IncludeCommentDeleted { get; set; } = false;


        [SwaggerParameter(Description = "The ID of the user to filter posts by. Optional parameter.")]
        public Guid? AuthorId { get; set; }


        // Default SortBy
        [SwaggerParameter(Description = "A list of sorting criteria in the format '<field>:<direction>'. Example: 'Name:asc' or 'Date:desc'.")]
        public new List<string> SortBy { get; set; } = new List<string>(){"PostId:asc"};
    }
    public class DateFormatConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime?);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(((DateTime)value).ToString("dd/MM/yyyy")); 
            }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            if (reader.Value == null)
            {
                throw new JsonSerializationException($"Invalid date format");
            }
            var dateString = reader.Value.ToString();
            if(dateString == null)
            {
                throw new JsonSerializationException($"Invalid date format");
            }

            if (DateUtils.TryParseDate(dateString, out var parsedDate))
            {
                return parsedDate; // Trả về ngày với thời gian là 00:00
            }

            throw new JsonSerializationException($"Invalid date format: {dateString}");
        }
    }
}
