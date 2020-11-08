using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    class Ex003
    {
        public void Run()
        {
            Examples.Model.Account acc = new Examples.Model.Account();
            //원래는 Works 폴더 안에 또 Model 만들어야 함
            acc.money = 0;
            int order;
            int val;

            Console.WriteLine("*************** 안녕하세요 Road Bank입니다 ***************");
            Console.WriteLine("1: 계좌 만들기");
            Console.WriteLine("2: 잔액 조회");
            Console.WriteLine("3: 입금");
            Console.WriteLine("4: 출금");
            Console.WriteLine("0: 종료");
            Console.WriteLine("**********************************************************");

            while (true)
            {
                Console.Write("사용자: ");
                order = Convert.ToInt32(Console.ReadLine());

                switch (order)
                {
                    case 1:
                        Console.WriteLine("통장 고유이름을 입력하세요");
                        Console.Write("사용자: ");
                        acc.acc_name = Console.ReadLine();

                        Console.WriteLine("통장 개설자의 이름을 입력하세요");
                        Console.Write("사용자: ");
                        acc.cus_name = Console.ReadLine();

                        Console.WriteLine("'{0}'님의 '{1}'이 개설되었습니다.", acc.cus_name, acc.acc_name);

                        continue;
                    case 2:
                        Console.WriteLine("잔액은 '{0}'원입니다.", acc.money);

                        continue;
                    case 3:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        Console.Write("사용자: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        acc.money += val;
                        Console.WriteLine("입금되었습니다.");

                        continue;
                    case 4:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        Console.Write("사용자: ");
                        val = Convert.ToInt32(Console.ReadLine());

                        if (val < acc.money)
                        {
                            acc.money -= val;
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
