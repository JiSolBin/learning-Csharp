using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    class Ex002
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            using (StreamWriter sw = new StreamWriter(currentDirectory + @"\data\log.txt", true))
            {
                sw.WriteLine("프로그램 실행 시간: {0}", DateTime.Now);
            }
        }
    }
}
