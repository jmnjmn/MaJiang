using System;
using System.Collections.Generic;
using System.IO;

namespace mj
{
    public class DebugTest
    {
        private static List<List<Pai>> lt = new List<List<Pai>>();

        public static void Test(int n)
        {
            Pai np = new Pai() {Id = n,};
            foreach (var l in lt)
            {
                foreach (var p in l)
                {
                    Console.Write(p.Id + ", ");
                }

                if (HuPai.IsHu(l, np))
                {
                    Console.WriteLine("HU=" + n);
                }
                else
                {
                    Console.WriteLine("NNNN");
                }
            }
        }

        public static void ReadTest()
        {
            using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/test.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] arr = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    List<Pai> plist = new List<Pai>(13);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Pai p = new Pai();
                        p.Id = int.Parse(arr[i]);
                        plist.Add(p);
                    }

                    lt.Add(plist);
                }
            }
        }
    }
}