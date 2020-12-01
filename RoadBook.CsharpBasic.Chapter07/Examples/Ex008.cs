using System;
using System.Collections.Generic;
using System.Text;
using RoadBook.CsharpBasic.Chapter07.Examples.UserException;

namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    class Ex008
    {
        public void Run()
        {
            Console.Write("두개의 숫자를 입력하세요 : ");

            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Divide(num1, num2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new MyStyleException("0으로 나눌 수 없습니다!!");
            }

            return num1 / num2;
        }
    }
}
