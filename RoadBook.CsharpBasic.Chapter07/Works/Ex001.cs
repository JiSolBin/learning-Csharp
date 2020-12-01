using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    class Ex001
    {
        public void Run()
        {
            Boolean i = false;
            int num = 0;

            Console.Write("입력 : ");

            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("형식이 잘못됐습니다.");
                i = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("정수의 범위를 벗어났습니다.");
                i = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("오류가 발생했습니다.");
                Console.WriteLine("에러코드 : {0}", e.HResult);
                Console.WriteLine("에러메시지 : {0}", e.Message);
                i = true;
            }
            finally
            {
                if (i)
                    num = -1;
            }

            Console.WriteLine("입력하신 숫자는 : {0}", num);
        }
    }
}
