using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainWord01 = objHello.ToString().Contains("Hello");
            bool isContainWord02 = vHello.Contains("Hello");
            bool isContainWord03 = dHello.Contains("Hello");
            //책에는 밑에 두줄도 .ToString() 붙였는데 복붙 실수인듯?

            #region >> 출력(region 기능(Ex006.cs) 실습)
            Console.WriteLine("object 변수에 Hello가 포함되어 있다 ? {0}", isContainWord01);
            Console.WriteLine("var 변수에 Hello가 포함되어 있다 ? {0}", isContainWord02);
            Console.WriteLine("dynamic 변수에 Hello가 포함되어 있다 ? {0}", isContainWord03);
            #endregion
        }
    }
}
