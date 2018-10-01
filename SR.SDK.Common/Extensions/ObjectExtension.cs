using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SR.SDK.Common.Extensions
{
    public static class ObjectExtension
    {
        public static bool IsInstanceOf(this object instance, Type requiredType)
        {
            return instance.GetType().IsInstanceOfType(requiredType);
        }

        public static Type GetGenericType(this object instance)
        {
            return instance.GetType().GetGenericTypeDefinition();
        }

        public static bool IsExtends(this object instance, Type requiredType)
        {
            return instance.GetType().IsExtends(requiredType);
        }

        public static bool Implements(this object instance, Type interfaceType)
        {
            return instance.GetType().GetInterfaces()
                       .Where(i => i.FullName == interfaceType.FullName)
                       .Count() > 0;
        }

        public static object InvokeMethod(this object instance, string methodName)
        {
            return InvokeMethod(instance, methodName, null);
        }

        public static object InvokeMethod(this object instance, string methodName, params object[] parameters)
        {
            MethodInfo methodInfo = instance.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            if (methodInfo == null) return null;

            return methodInfo.Invoke(instance, parameters);
        }

        public static Int32 ToInt32(this object value)
        {
            return Convert.ToInt32(value);
        }

        public static short ToShort(this object value)
        {
            return Convert.ToInt16(value);
        }

        public static long ToLong(this object value)
        {
            return Convert.ToInt64(value);
        }

        public static int? ToNullableInt32(this object value)
        {
            return value == null || string.IsNullOrEmpty(value.ToString()) ? null : Convert.ToInt32(value) as int?;
        }

        public static decimal? ToNullableDecimal(this string value)
        {
            return value == null || string.IsNullOrEmpty(value.ToString()) ? null : decimal.Parse(value) as decimal?;
        }

        public static DateTime ToDateTime(this object value)
        {
            return Convert.ToDateTime(value);
        }

        public static DateTime? ToNullableDateTime(this object value)
        {
            return value == null || string.IsNullOrEmpty(value.ToString()) ? null : Convert.ToDateTime(value) as DateTime?;
        }

        public static Boolean ToBoolean(this object value)
        {
            return Convert.ToBoolean(value);
        }

    }
}
