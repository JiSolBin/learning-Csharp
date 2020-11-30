using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    class Ex002
    {
        public void Run()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            list.Sort(); //내림차순은 어떻게 하지?

            Console.Write("오름차순 정렬 결과: ");
            Console.Write("{0}, ", list[0]);
            Console.Write("{0}, ", list[1]);
            Console.Write("{0}, ", list[2]);
            Console.Write("{0}, ", list[3]);
            Console.WriteLine("{0}", list[4]);
        }
    }
}
