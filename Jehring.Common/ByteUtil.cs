using System;
using System.Collections.Generic;
using System.Text;

namespace Jehring.Common
{
    public static class ByteUtil
    {
        public static string GetHexString(this byte[] bytearr)
        {
            var hash = new StringBuilder();
            foreach (byte theByte in bytearr)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
