using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Settings;

namespace WATERLINE.Helpers.Region
{
    public static class DateTimeHelper
    {
        static TimeZoneInfo timezone = TimeZoneInfo.FindSystemTimeZoneById(Config.RegionKey);
        public static DateTime CurrentDateTime()
        {
            return TimeZoneInfo.ConvertTime(DateTime.Now, timezone);
        }

        public static DateTime CurrentDate()
        {
            return TimeZoneInfo.ConvertTime(DateTime.Now, timezone).Date;
        }
    }
}
