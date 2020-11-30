using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex012
    {
        public void Run()
        {
            Hashtable hst = new Hashtable();
            hst.Add("korea", "한국");
            hst.Add("brazil", "브라질");
            hst.Add("canada", "캐나다");
            hst.Add("america", "미국");

            while (true)
            {
                Console.Write("단어를 입력하세요 : ");
                string word = Console.ReadLine();

                if (hst.Contains(word))
                {
                    Console.WriteLine("{0} : {1}", word, hst[word]);
                    Console.Write("단어를 삭제하시겠습니까? (Y/N) : ");
                    string delYN = Console.ReadLine();

                    if (delYN.ToUpper() == "Y")
                    {
                        hst.Remove(word);
                        Console.WriteLine("단어가 삭제되었습니다.");
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("단어 검색결과가 없습니다.");
                    Console.Write("단어를 추가하시겠습니까? (Y/N) : ");
                    string addYN = Console.ReadLine();

                    if (addYN.ToUpper() == "Y")
                    {
                        Console.Write("뜻을 입력해주세요 : ");
                        string val = Console.ReadLine();
                        hst.Add(word, val);
                        Console.WriteLine("단어가 추가되었습니다.");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
