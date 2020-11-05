using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    class Ex001
    {
        public void Run()
        {
            Console.Write("첫 번재 값을 입력해주세요 : ");
            string str1 = Console.ReadLine();
            Console.Write("두 번째 값을 입력해주세요 : ");
            string str2 = Console.ReadLine();

            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);

            bool boolnum = (num1 > num2);

            Console.WriteLine("{0} > {1} : {2}", num1, num2, boolnum);
        }
    }
}
