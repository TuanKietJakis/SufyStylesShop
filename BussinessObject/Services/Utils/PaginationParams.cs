using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO
{
    public class PaginationParams
    {
        [SwaggerParameter(Description = "The page number for pagination. The default is 1.")]
        public int PageNumber { get; set; } = 1;
        [SwaggerParameter(Description = "The number of items to display per page. The default is 10.")]
        public int PageSize { get; set; } = 10;
        [SwaggerParameter(Description = "Filter to include/exclude soft-deleted items. Set to true to only include deleted items, false to exclude, and null to include both.")]
        public bool? IsDeleted { get; set; }
        [SwaggerParameter(Description = "A list of sorting criteria in the format '<field>:<direction>'. Example: 'Name:asc' or 'Date:desc'.")]
        public List<string> SortBy { get; set; } = new List<string>(); // format '<field>:<direction>'
    }
}
