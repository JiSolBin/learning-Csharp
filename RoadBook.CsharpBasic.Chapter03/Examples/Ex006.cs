using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Ex006
    {
        public void Run()
        {
            Console.Write("숫자를 하나 입력해주세요 : ");
            String str = Console.ReadLine();

            int num = Convert.ToInt32(str);

            if (num == 0)
                Console.WriteLine("입력한 수는 0입니다.");
            else if (num > 0)
                Console.WriteLine("입력한 수는 양수입니다.");
            else
                Console.WriteLine("입력한 수는 음수입니다.");

            if (num != 0)
            {
                if (num % 2 == 0)
                    Console.WriteLine("입력한 수는 짝수입니다.");
                else
                    Console.WriteLine("입력한 수는 홀수입니다.");
            }
        }
    }
}
