using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RoadBook.Csharpbasic.Chapter04.Works
{
    class Ex002
    {
        public void Run()
        {
            Random rand = new Random();
            int target = rand.Next(1, 50);

            int num = 0;
            int count = 0;

            while (true) {
                Console.Write("사용자: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == target)
                    break;

                if (num > target)
                        Console.WriteLine("틀렸습니다. DOWN!");
                    else
                        Console.WriteLine("틀렸습니다. UP!");
            }

            Console.WriteLine("정답입니다!");
        }
    }
}
