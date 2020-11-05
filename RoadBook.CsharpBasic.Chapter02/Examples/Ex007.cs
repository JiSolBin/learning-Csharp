using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex007
    {
        public void Run()
        {
            int kor = 100;
            int eng = 100;
            int math = 98;
            int sports = 97;

            Console.WriteLine("총 점수 : {0}", kor + eng + math + sports);
            Console.WriteLine("평균 : {0}", (kor + eng + math + sports)/4);
            Console.WriteLine("평균 : {0}", (double)(kor + eng + math + sports) / 4);
        }
    }
}
