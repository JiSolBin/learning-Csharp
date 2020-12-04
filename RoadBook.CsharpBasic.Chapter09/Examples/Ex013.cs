using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    class Ex013
    {
        public void Run()
        {
            int cnt;

            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student { ID = "S001", Name = "Dexter", Grade = 3, Major = "Softward"},
                new Model.Student { ID = "D001", Name = "Ellin", Grade = 3, Major = "Design"},
                new Model.Student { ID = "S002", Name = "Jeffrey", Grade = 4, Major = "Softward"},
                new Model.Student { ID = "D002", Name = "Sienna", Grade = 4, Major = "Design"},
                new Model.Student { ID = "S003", Name = "Pil", Grade = 4, Major = "Softward"},
                new Model.Student { ID = "S006", Name = "Clinit", Grade = 3, Major = "Softward"},
                new Model.Student { ID = "S004", Name = "Khan", Grade = 2, Major = "Softward"},
                new Model.Student { ID = "A001", Name = "Mike", Grade = 2, Major = "Advertisement"},
                new Model.Student { ID = "S005", Name = "Sven", Grade = 2, Major = "Softward"},
                new Model.Student { ID = "T001", Name = "Peter", Grade = 1, Major = "Theater"},
            };

            students.GroupBy(s => s.Major, (key, g) => new { Major = key, Count = g.Count() }).ToList()
                .ForEach(s => Console.WriteLine("{0} : {1}", s.Major, s.Count));
            //전공별로 그룹화 됨 / Major에는 major 값을 다시 담고..(?) Count에는 그룹의 개수를 담음
            //(key, g)는 Dictionary<ket, val> 생각하면 될듯
        }
    }
}
