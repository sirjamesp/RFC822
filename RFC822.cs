using System;
using System.Collections.Generic;
using System.Text;

//example = Wed, 02 Oct 2002 08:00:00 EST 
namespace ESV.Utilities
{
    public class RFC822
    {
        public static string CreateTime(DateTime dt)
        {
            string rfc = "";

            string day, date, month, year, hour, minute, second, time = "";
            day = dt.DayOfWeek.ToString().Substring(0, 3) + ", ";
            if (dt.Day < 10)
                date = "0" + dt.Day.ToString() + " ";
            else
                date = dt.Day.ToString() + " ";
            month = GetMonth(dt) + " ";
            year = dt.Year.ToString() + " ";
            long hr = dt.Hour;
            long min = dt.Minute;
            long sec = dt.Second;
            if (hr < 10)
                hour = "0" + hr.ToString();
            else
                hour = hr.ToString();
            if (min < 10)
                minute = "0" + min.ToString();
            else
                minute = min.ToString();
            if (sec < 10)
                second = "0" + sec.ToString();
            else
                second = sec.ToString();
            time = hour + ":" + minute + ":" + second + " ";

            rfc = day + date + month + year + time + "EST";

            return rfc;
        }
        public static string GetMonth(DateTime dt)
        {
            string month = "";

            if (dt.Month == 1)
                month = "Jan";
            if (dt.Month == 2)
                month = "Feb";
            if (dt.Month == 3)
                month = "Mar";
            if (dt.Month == 4)
                month = "Apr";
            if (dt.Month == 5)
                month = "May";
            if (dt.Month == 6)
                month = "Jun";
            if (dt.Month == 7)
                month = "Jul";
            if (dt.Month == 8)
                month = "Aug";
            if (dt.Month == 9)
                month = "Sep";
            if (dt.Month == 10)
                month = "Oct";
            if (dt.Month == 11)
                month = "Nov";
            if (dt.Month == 12)
                month = "Dec";


            return month;
        }
    }
}
