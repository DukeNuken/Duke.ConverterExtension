using System;

namespace Duke.ConverterExtension
{
    public static class ConverterExtension
    {
        public static String ToSaveString(this object obj)
        {
            if (obj == null)
                return "";

            return obj.ToString();
        }

        public static String ToSaveTrimString(this object obj)
        {
            if (obj == null)
                return "";

            return obj.ToString().Trim();
        }

        public static String ToSaveTrimUpperString(this object obj)
        {
            if (obj == null)
                return "";

            return obj.ToString().Trim().ToUpper();
        }

        public static int ToSaveInt(this object obj)
        {
            if (obj == null)
                return 0;
            int result = 0;
            if (Int32.TryParse(obj.ToSaveString(), out result))
                return result;
            return result;
        }

        public static decimal ToSaveDecimal(this object obj)
        {
            if (obj == null)
                return 0;
            decimal result = 0;
            if (decimal.TryParse(obj.ToSaveString(), out result))
                return result;
            return result;
        }

        public static string ToSaveDbString(this object obj)
        {
            if (obj == null)
                return "";

            return (obj.ToSaveString() ?? "").Replace("'", "''");
        }

        public static string ToSaveDbString(this object obj, int limit)
        {
            if (obj == null)
                return "";

            string temp = obj.ToSaveString().Trim();
            if (limit <= 0 || temp.Length <= limit)
            {
                return (temp ?? "").Replace("'", "''");
            }
            else return temp.Substring(0, limit).Replace("'", "''");
        }

        public static bool ToSaveBool(this object obj)
        {
            bool Temp = false;
            if (obj == null)
                return false;

            string str = obj.ToSaveString();
            if (!String.IsNullOrEmpty(str))
            {
                bool.TryParse(str, out Temp);
            }

            return Temp;
        }

        public static double ToSaveDouble(this object obj)
        {
            if (obj == null)
                return 0;
            double result = 0;
            if (double.TryParse(obj.ToSaveString(), out result))
                return result;
            return result;
        }

        public static DateTime ToSaveDateTime(this object obj)
        {
            DateTime retVal = DateTime.MinValue;
            if (obj != null)
            {
                DateTime.TryParse(obj.ToSaveString(), out retVal);
            }
            return retVal;
        }
    }
}
