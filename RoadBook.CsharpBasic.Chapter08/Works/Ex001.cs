using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    class Ex001
    {
        public void Run()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\지솔빈\source\repos\MyFirstApp\RoadBook.CsharpBasic.Chapter08\Examples");

            FileInfo[] files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine(file.Name);
            }
        }
    }
}
