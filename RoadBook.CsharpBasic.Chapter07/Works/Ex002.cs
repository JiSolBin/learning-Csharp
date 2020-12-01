using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    class Ex002
    {
        public void Run()
        {
            byte num;
            Random rand = new Random();
            int target = rand.Next(0, 255);

            while (true)
            {
                Console.Write("0~255 사이의 숫자를 입력해주세요 : ");

                try
                {
                    num = Convert.ToByte(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("형식이 잘못됐습니다.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("범위가 잘못됐습니다.");
                    continue;
                }

                if(num == Convert.ToByte(target))
                {
                    Console.WriteLine("정답입니다!"); //맞추는거 500년 걸림
                    break;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                    continue;
                }
            }
        }
    }
}
