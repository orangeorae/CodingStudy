using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace CodingCSharp
{
    internal class _0408
    {
        class FantasyCreature
        {
            public int m_number;

            public FantasyCreature(int number)
            {

                m_number = number;
            }

            public void content(string name)
            {

                if (name == "드래곤")
                {
                    Console.WriteLine("드래곤은 강력한 힘과 불을 뿜는 전설 속의 거대한 용이다.");
                }
                else if (name == "피닉스")
                {
                    Console.WriteLine("피닉스는 스스로 불타 죽고 부활하는 불사조로 재생의 상징이다.");
                }
                else if (name == "유니콘")
                {
                    Console.WriteLine("유니콘은 이마에 뿔이 달린 순수하고 신성한 힘을 지닌 말이다.");
                }
                else if (name == "페가수스")
                {
                    Console.WriteLine("페가수스는 날개가 달려 하늘을 나는 신화 속의 천마이다.");
                }
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, FantasyCreature> FantasyBook = new Dictionary<string, FantasyCreature>();
            FantasyBook.Add("드래곤", new FantasyCreature(101));
            FantasyBook.Add("피닉스", new FantasyCreature(111));
            FantasyBook.Add("페가수스", new FantasyCreature(121));
            FantasyBook.Add("유니콘", new FantasyCreature(131));

            Console.Write("찾고싶은 동물의 이름을 입력해주세요: ");
            string foundKey = Console.ReadLine();


            if (FantasyBook.ContainsKey(foundKey) == false)
            { //ContainsKey 사용해보기

                Console.WriteLine("사전에 없는 판타지 동물입니다.");
                return;
            }
            FantasyCreature foundFantasyCreature = FantasyBook[foundKey];

            Console.WriteLine($"찾으신 동물의 도감 페이지는: {foundFantasyCreature.m_number}P 입니다.");

            if (foundFantasyCreature != null) //객체의 널 체크 넣어보기
            {
                foundFantasyCreature.content(foundKey);
                FantasyBook.Remove(foundKey);
            }

        }

    }

}

