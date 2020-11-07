using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.Csharpbasic.Chapter04.Examples
{
    class Ex003
    {
        public void Run()
        {
            for (int i = 1; i <=  9; i++) //if문을 사용해서 9까지..그리고 break로 빠져나오라 했는데 하기 싫음
            {
                Console.WriteLine("2 * {0} = {1}", i, 2 * i);
            }
        }
    }
}
