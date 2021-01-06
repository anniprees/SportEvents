using System;

namespace SportEvents.Domain.Common
{
    public abstract class BaseEntity
    {
        public static string Unspecified => Word.Unspecified;
        public static DateTime UnspecifiedDate => DateTime.MinValue;
        public static double UnspecifiedDouble => double.NaN;
        public static decimal UnspecifiedDecimal => decimal.MaxValue;
        public static int UnspecifiedInteger => 0;
        protected static bool isUnspecified(string s)
            => string.IsNullOrWhiteSpace(s) || s.Trim() == Unspecified;
    }

    public static class Word
    {
        public static string Unspecified => "Unspecified";
        public static string List => "List";
        public static string None => "None";
        public static string Null => "Null";
    }
}

