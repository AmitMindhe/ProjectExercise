using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExercise.Core
{
    public static class DateTimeHelper
    {
        public static DateTime UtcToLocalDateTime(this DateTime date)
        {
            var clientTimeZone = TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["LocalTimeZone"].ToString());
            var returnDate = TimeZoneInfo.ConvertTimeFromUtc(date, clientTimeZone);
            return returnDate;
        }

        public static DateTime LocalToUtcDateTime(this DateTime date)
        {
            var clientTimeZone = TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["LocalTimeZone"].ToString());
            var returnDate = TimeZoneInfo.ConvertTimeToUtc(date, clientTimeZone);
            return returnDate;
        }
    }
}