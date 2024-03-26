using System.Globalization;

namespace DocPlannerStudyCase.Helper
{
    public class DateHelper
    {
        public static DateTime? String2DateTime(string dateString)
        {
            DateTime? dateVal;
            try
            {
                DateTime tmpDateTime = DateTime.Parse(dateString);
                dateVal = DateTime.SpecifyKind(tmpDateTime, DateTimeKind.Utc);
            }
            catch (Exception e)
            {
                dateVal = null;
            }

            return dateVal;
        }

        public static string DateTime2UTCDateString(DateTime dt)
        {
            DateTime tmp = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
            return tmp.ToString("o");
        }

        public static bool isValid(string dateString, string format)
        {
            DateTime tmp;
            return DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp);
        }
    }
}
