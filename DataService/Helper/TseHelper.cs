using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Helper
{
    public static class TseHelper
    {
        public static int GetServiceInterval(string name)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["Tse" + name + "Interval"]);
        }

        public static int GetServiceMilisecondInterval(string name)
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["Tse" + name + "Interval"]) * 60000;
        }

        public static int FromDate
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["InstTradeFromDate"]);
            }
        }

        public static int ToDate
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["InstTradeToDate"]);
            }
        }

    }
}
