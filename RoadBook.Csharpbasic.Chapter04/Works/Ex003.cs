using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.Csharpbasic.Chapter04.Works
{
    class Ex003
    {
        public void Run()
        {
            int acc = 0;
            int order = 0;
            int val = 0;

            Console.WriteLine("*************** 안녕하세요 Road Bank입니다 ***************");
            Console.WriteLine("1: 잔액 조회");
            Console.WriteLine("2: 입금");
            Console.WriteLine("3: 출금");
            Console.WriteLine("0: 종료");
            Console.WriteLine("**********************************************************");

            while (true)
            {
                Console.Write("사용자: ");
                order = Convert.ToInt32(Console.ReadLine());

                switch (order)
                {
                    case 1:
                        Console.WriteLine("잔액은 '{0}'원입니다.", acc);

                        continue;
                    case 2:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        Console.Write("사용자: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        acc += val;
                        Console.WriteLine("입금되었습니다.");

                        continue;
                    case 3:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        Console.Write("사용자: ");
                        val = Convert.ToInt32(Console.ReadLine());

                        if (val < acc)
                        {
                            acc -= val;
                            Console.WriteLine("출금되었습니다.");
                        }
                        else
                            Console.WriteLine("잔액이 부족합니다");

                        continue;
                    case 0:
                        Console.WriteLine("감사합니다");

                        break;
                    default:
                        Console.WriteLine("잘못된 입력 입니다");

                        continue;
                }

                break;
            }
        }
    }
}
