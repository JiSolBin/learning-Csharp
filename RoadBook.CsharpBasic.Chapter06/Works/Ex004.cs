using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    class Ex004
    {
        public void Run()
        {
            Dictionary<string, string[]> dic = new Dictionary<string, string[]>();
            //책에서는 List<string> 형태로 구현하라 했는데 데이터 정해져 있으니 배열 씀
            string[] groupA = { "대한민국", "프랑스", "미국", "이집트" };
            string[] groupH = { "일본", "브라질", "독일", "스페인" };

            dic.Add("A", groupA);
            dic.Add("H", groupH);

            while (true)
            {
                Console.Write("조 추첨 결과 어느 조를 조회할까요? (q: 종료) ");
                string str = Console.ReadLine();

                if (str == "q")
                {
                    Console.Write("종료되었습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("{0}조에 속한 나라는", str);

                    foreach(string str2 in dic[str])
                    {
                        Console.WriteLine("{0}", str2);
                    }

                    Console.Write("입니다. ");
                }
            }
        }
    }
}
