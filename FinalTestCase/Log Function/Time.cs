using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestCase
{
    public static class Time
    {
        public static string GetFormatedDateNow(string testname)
        {
            DateTime datum = DateTime.Now;

            string day = datum.Day.ToString();
            string month = datum.Month.ToString();
            string year = datum.Year.ToString();
            string hour = datum.Hour.ToString();
            string minute = datum.Minute.ToString();
            string second = datum.Second.ToString();

            string datumFormat = testname + "-" + day + "-" + month + "-" + year + "-" + hour + "_" + minute + "_" + second;

            return datumFormat;
        }

        internal static string GetFormatedDateNow(object testname)
        {
            throw new NotImplementedException();
        }
    }
}
