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
            var bytes = Encoding.UTF8.GetBytes(source);
            return Convert.ToBase64String(bytes);
        }

        public static string FromBase64(this string source)
        {
            var bytes = Convert.FromBase64String(source);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string ToMD5Hash(this string source)
        {
            //System.Security.Cryptography.MD5
            
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
            return bool.Parse(source);
        }

        public static bool ToBooleanTryParse(this string source)
        {
            bool value = false;
            bool.TryParse(source, out value);
            return value;
        }

        public static byte ToByte(this string source)
        {
            return byte.Parse(source);
        }

        public static byte ToByteTryParse(this string source)
        {
            byte byt = byte.MinValue;
            byte.TryParse(source, out byt);
            return byt;
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
            return ushort.Parse(source);
        }

        public static ushort ToUInt16TryParse(this string source)
        {
            ushort value;
            ushort.TryParse(source, out value);
            return value;
        }

        public static uint ToUInt32(this string source)
        {
            return uint.Parse(source);
        }

        public static uint ToUInt32TryParse(this string source)
        {
            uint value;
            uint.TryParse(source, out value);
            return value;
        }

        public static ulong ToUInt64(this string source)
        {
            return ulong.Parse(source);
        }

        public static ulong ToUInt64TryParse(this string source)
        {
            ulong value;
            ulong.TryParse(source, out value);
            return value;
        }

        public static bool IsNumeric(this string value)
        {
            double d;
            return double.TryParse(value, out d);
        }

        public static bool IsDateTime(this string value)
        {
            DateTime d;
            return DateTime.TryParse(value, out d);
        }

        public static bool IsInt32(this string source)
        {
            Int32 value;
            return Int32.TryParse(source, out value);
        }

        public static bool IsInt64(this string source)
        {
            Int64 value;
            return Int64.TryParse(source, out value);
        }

        public static bool IsShort(this string source)
        {
            short value;
            return short.TryParse(source, out value);
        }

        public static bool IsDecimal(this string source)
        {
            decimal value;
            return decimal.TryParse(source, out value);
        }

        public static bool IsBoolean(this string source)
        {
            bool value;
            return bool.TryParse(source, out value);
        }

        public static short ToShort(this string value)
        {
            short shortout;
            short.TryParse(value, out shortout);
            return shortout;
        }

        public static long ToLong(this string value)
        {
            long longout;
            long.TryParse(value, out longout);
            return longout;
        }

        

    }
}
