using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.Csharpbasic.Chapter04.Examples
{
    class Ex005
    {
        public void Run()
        {
            int result = 1;

            for(int i = 5; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine("5! = {0}", result);
        }
    }
}
