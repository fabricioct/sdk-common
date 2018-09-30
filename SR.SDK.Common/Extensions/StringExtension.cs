using System;
using System.Collections.Generic;
using System.Text;

namespace SR.SDK.Common.Extensions
{
    public static class StringExtension
    {
        public static string UppercaseFirstLetter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        public static int WordCount(this string source)
        {
            return source.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ToReticence(this string content, int maxLength)
        {
            if (content == null || content.Length <= maxLength)
                return content;

            content = content.Substring(0, content.Length >= (maxLength - 3) ? (maxLength - 3) : content.Length) + "...";

            return content;
        }

        public static string ToBase64(this string source)
        {
            throw new NotImplementedException();
        }

        public static string FromBase64()
        {
            throw new NotImplementedException();
        }

        public static string ToMD5Hash(this string source)
        {
            throw new NotImplementedException();
        }

        public static bool EqualsIgnoreCase(this string source, string value)
        {
            return source.Equals(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsNullOrEmpty(this string source)
        {
            return string.IsNullOrEmpty(source);
        }

        public static int ToInt32TryParse(this string source)
        {
            int value = int.MinValue;
            int.TryParse(source, out value);
            return value;
        }

        public static int ToInt32(this string source)
        {
            return int.Parse(source);
        }

        public static bool ToBoolean(this string source)
        {
            return Convert.ToBoolean(source);
        }

        public static bool ToBooleanTryParse(this string source)
        {
            bool value = false;
            bool.TryParse(source, out value);
            return value;
        }

        public static byte ToByte(this string source)
        {
            return Convert.ToByte(source);
        }

        public static char ToChar(this string source)
        {
            return Convert.ToChar(source);
        }

        public static DateTime ToDateTime(this string source)
        {
            throw new NotImplementedException();
        }

        public static decimal ToDecimal(this string source)
        {
            throw new NotImplementedException();
        }

        public static double ToDouble(this string source)
        {
            throw new NotImplementedException();
        }

        public static short ToInt16(this string source)
        {
            throw new NotImplementedException();
        }

        public static long ToInt64(this string source)
        {
            throw new NotImplementedException();
        }

        public static sbyte ToSByte(this string source)
        {
            throw new NotImplementedException();
        }

        public static float ToSingle(this string source)
        {
            throw new NotImplementedException();
        }

        public static ushort ToUInt16(this string source)
        {
            throw new NotImplementedException();
        }

        public static uint ToUInt32(this string source)
        {
            throw new NotImplementedException();
        }

        public static ulong ToUInt64(this string source)
        {
            throw new NotImplementedException();
        }
    }
}
