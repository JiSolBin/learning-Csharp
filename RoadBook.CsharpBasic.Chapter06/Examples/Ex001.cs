using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex001
    {
        public void Run()
        {
            string weather = "sunny,rainy,cloudy,snow";

            var weathers = weather.Split(",");

            Console.WriteLine(weather.GetType());
            Console.WriteLine(weathers.GetType());
        }
    }
}
