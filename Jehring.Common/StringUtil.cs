using System;
using System.Collections.Generic;
using System.Text;

namespace Jehring.Common
{
    public static class StringUtil
    {
        public static string Left(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            maxLength = Math.Abs(maxLength);
            return value.Length > maxLength ? value.Substring(0, maxLength) : value;
        }

        public static string Right(this string sValue, int iMaxLength)
        {
            if (string.IsNullOrEmpty(sValue) || sValue.Length <= iMaxLength)
                return sValue;
            sValue = sValue.Substring(sValue.Length - iMaxLength, iMaxLength);
            return sValue;
        }

        public static short ToInt16(this string value) => Convert.ToInt16(value);

        public static int ToInt32(this string value) => Convert.ToInt32(value);

        public static long ToInt64(this string value) => Convert.ToInt64(value);

        public static double ToDouble(this string value) => double.Parse(value);

        public static decimal ToDecimal(this string value) => decimal.Parse(value);

        public static float ToFloat(this string value) => float.Parse(value);

        public static bool ToBoolean(this string value) => bool.Parse(value);

        public static string Base64Encode(this string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));

        public static string Base64Decode(this string base64EncodedData) => Encoding.UTF8.GetString(Convert.FromBase64String(base64EncodedData));
    }
}
