using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Jehring.Common
{
    public static class Hash
    {
        public enum HashType
        {
            SHA1, SHA256, SHA512, MD5
        }
        public static string GetHash(this string text, HashType type)
        {
            switch (type)
            {
                case HashType.SHA256:
                    return text.ToSHA256();
                case HashType.SHA512:
                    return text.ToSHA512();
                case HashType.SHA1:
                    return text.ToSHA1();
                case HashType.MD5:
                    return text.ToMD5();
                default:
                    throw new ArgumentException("Enum HashType not supported!");
            }
        }

        public static string ToSHA256(this string text) => SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(text)).GetHexString();
        public static string ToSHA512(this string text) => SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(text)).GetHexString();
        public static string ToSHA1(this string text) => SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(text)).GetHexString();
        public static string ToMD5(this string text) => MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(text)).GetHexString();




    }
}
