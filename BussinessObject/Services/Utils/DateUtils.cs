using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Utils
{
    public static class DateUtils
    {
        private static readonly string[] _formats = { "dd/MM/yyyy", "dd-MM-yyyy" };

        public static bool TryParseDate(string dateString, out DateTime parsedDate)
        {
            parsedDate = default;
            if (string.IsNullOrEmpty(dateString))
            {
                return false;
            }

            if (DateTime.TryParseExact(dateString, _formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
            {
                parsedDate = date.Date; // Đảm bảo thời gian là 00:00
                return true;
            }

            return false;
        }
    }

}
