using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    class Ex001
    {
        public void Run()
        {
            string[] age = new string[10];
            int teenage = 0;
            int twenty = 0;
            int senior = 0;

            //30-50 귀찮

            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0}번째 사람의 나이를 입력하세요: ", i + 1);
                age[i] = Console.ReadLine();
            }

            Console.WriteLine("나이 입력이 완료되었습니다.");

            Console.Write("20대 미만: ");
            for (int i = 0; i < 10; i++)
            {
                if(Convert.ToInt32(age[i]) < 20)
                {
                    teenage++;
                }
            }
            Console.WriteLine("{0}명", teenage);

            Console.Write("20대: ");
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToInt32(age[i]) >= 20 && Convert.ToInt32(age[i]) < 30)
                {
                    twenty++;
                }
            }
            Console.WriteLine("{0}명", twenty);

            Console.Write("60대 이상: ");
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToInt32(age[i]) >= 60)
                {
                    senior++;
                }
            }
            Console.WriteLine("{0}명", senior);
        }
    }
}
