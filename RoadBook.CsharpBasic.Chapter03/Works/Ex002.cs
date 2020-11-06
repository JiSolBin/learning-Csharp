using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    class Ex002
    {
        public void Run()
        {
            Console.Write("중간고사 점수를 입력해주세요 : ");
            String str1 = Console.ReadLine();
            Console.Write("기말고사 점수를 입력해주세요 : ");
            String str2 = Console.ReadLine();

            float avg = (Convert.ToSingle(str1) + Convert.ToSingle(str2))/2;

            if (avg >= 90)
                Console.WriteLine("A학점 입니다.");
            else if (avg >= 80)
                Console.WriteLine("B학점 입니다.");
            else if (avg >= 70) //문제에서 70~80점은 C, 70 이하는 F라고 애매하게 적어놔서 걍 70미만 F라 침
                Console.WriteLine("C학점 입니다.");
            else
                Console.WriteLine("F학점 입니다.");
        }
    }
}
