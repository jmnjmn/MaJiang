using System;
using System.Collections.Generic;

namespace mj
{
    public class XiPai
    {
        public static void Xi(ref List<Pai> lt)
        {
            int count = 4 * 17 * 2;
            Random rd = new Random();
            for (int i = count; i > 0; i--)
            {
                int r = rd.Next(0, i);
                var t = lt[r];
                lt[r] = lt[i - 1];
                lt[i - 1] = t;
            }
        }
    }
}