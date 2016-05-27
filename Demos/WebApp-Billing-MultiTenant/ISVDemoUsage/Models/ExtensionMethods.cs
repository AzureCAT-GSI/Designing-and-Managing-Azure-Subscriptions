using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISVDemoUsage.Models
{
    public static class ExtensionMethods
    {
        public static string GetEncodedDate(this DateTime d, bool includeHour)
        {
            var datePart = d.ToString("yyyy-MM-dd");
            string timePart = "00:00:00Z";
            if(includeHour)
            {
                timePart = d.ToString("HH:00:00Z");
            }
            string ret = string.Concat(datePart, "+", HttpContext.Current.Server.UrlEncode(timePart));
            return ret;
        }
    }
}