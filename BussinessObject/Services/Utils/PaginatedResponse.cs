using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO
{
    public class PaginatedResponse<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
        public List<T> Items { get; set; }
        public PaginatedResponse() { }
        public PaginatedResponse(int page, int pageSize, int totalItems, List<T> items)
        {
            Page = page;
            PageSize = pageSize;
            TotalItems = totalItems;
            Items = items;
        }
    }
}
