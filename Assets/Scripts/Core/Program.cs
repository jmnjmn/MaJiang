using System;
using System.Collections.Generic;

namespace mj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //PlayRound.Start();

            DebugTest.ReadTest();
            while (true)
            {
                var info = Console.ReadLine();
                int num = 0;
                if (!int.TryParse(info, out num))
                {
                    return;
                }

                DebugTest.Test(num);
            }
        }
    }
}