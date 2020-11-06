using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    class Ex001
    {
        public void Run()
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);

            Console.Write("{0} + {1} =  ", num1, num2);
            String str = Console.ReadLine();

            if (num1 + num2 == Convert.ToInt32(str))
                Console.WriteLine("정답입니다.");
            else
                Console.WriteLine("오답입니다.");
        }
    }
}
