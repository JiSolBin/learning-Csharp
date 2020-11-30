using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    class Ex003
    {
        public void Run()
        {
            Queue<string> que = new Queue<string>();

            Console.Write("몇 명의 인원에게 무료 혜택을 제공할까요? ");
            int freemov = Convert.ToInt32(Console.ReadLine());

            while(true)
            {
                Console.Write("이름을 입력해주세요(q: 종료): ");
                string name = Console.ReadLine();

                if (name == "q")
                {
                    break;
                }
                else
                {
                    que.Enqueue(name);
                }
            }

            Console.WriteLine("무료 영화 관람권 당첨자는");

            foreach(string str in que)
            {
                if (freemov == 0)
                    break;

                Console.WriteLine(str.ToString());
                freemov--;
            }
        }
    }
}
