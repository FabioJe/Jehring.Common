using System;
using System.Collections.Generic;
using System.Text;

namespace Jehring.Common
{
    public static class IntegerUtil
    {
        public static int[] ToInt32Array(this string[] vs)
        {
            if (vs == null)
                return null;
            int[] numArray = new int[vs.Length];
            for (int index = 0; index < vs.Length; ++index)
                numArray[index] = Convert.ToInt32(vs[index]);
            return numArray;
        }
        public static long[] ToInt64Array(this string[] vs)
        {
            if (vs == null)
                return null;
            long[] numArray = new long[vs.Length];
            for (int index = 0; index < vs.Length; ++index)
                numArray[index] = Convert.ToInt64(vs[index]);
            return numArray;
        }
    }
}
