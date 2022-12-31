using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Helper
{
    public static class ConvertDateTime
    {
        public static long ToUnixEpochDate(this DateTime date)
        {
            return new DateTimeOffset(date).ToUniversalTime().ToUnixTimeSeconds();
        }


        public static DateTime TimestampToDateTime(this long timestamp)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(timestamp).DateTime;
        }

        public static int BetweenMonth(string date1, string date2)
        {
            int result = 0;
            var splited1 = date1.Split('/');
            var splited2 = date2.Split('/');
            if (splited1[0] == splited2[0])
                result = Convert.ToInt32(splited1[1]) - Convert.ToInt32(splited2[1]);

            else if (Convert.ToInt32(splited1[0]) > Convert.ToInt32(splited2[0]))
                result = 12 + Convert.ToInt32(splited1[1]) - Convert.ToInt32(splited2[1]);

            else
            {

            }
            return result;
        }

        public static int MiladiToTseDate(this DateTime date)
        {
            return date.Year * 10000 + date.Month * 100 + date.Day;
        }
    }
}
