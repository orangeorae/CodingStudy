using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace CodingCSharp
{

    public class FantasticCreature
    {
        public string name;
        public int level;
        public Rank rank;
        public enum Rank
        {
            None = 0,
            Rare, // 슬라임
            Epic, // 그리핀
            Legendary // 드래곤

        }

        public FantasticCreature(string name, int level, Rank rank)
        {
            this.name = name;
            this.level = level;
            this.rank = rank;

        }
        public FantasticCreature() { }
        public void CreatureGuide()
        {
            if (name == "드래곤")
            {
                Console.WriteLine($"찾으신 판타지 동물 {name}의 레벨은 100 이고 등급은 {Rank.Legendary}입니다.");
            }

            else if (name == "그리핀")
            {
                Console.WriteLine($"찾으신 판타지 동물 {name}의 레벨은 50 이고 등급은 {Rank.Epic}입니다.");
            }

            else if (name == "슬라임")
            {
                Console.WriteLine($"찾으신 판타지 동물 {name}의 레벨은 10 이고 등급은 {Rank.Rare}입니다.");
            }

        }

        public void Move(string name)
        {
            Console.WriteLine($"{name}가 움직이기 시작합니다.");
        }

        public virtual void Skill(string name, string skill)
        {
            Console.WriteLine($"{name}이 {skill}을(를) 사용합니다.");
        }
    }

    class Unicorn : FantasticCreature
    {
        public void Fly(string name)
        {
            Console.WriteLine($"{name}은 뿔이 달린 판타지 동물이다.");
        }

        public override void Skill(string name, string skill) // 오버라이드 
        {
            Console.WriteLine($"{name}이 {skill}을(를) 멋지게 사용합니다.");
        }
    }

    internal class _0403_CheckPoint
    {
        static void Main(string[] args)
        {
            FantasticCreature dCreature = new FantasticCreature("드래곤", 100, FantasticCreature.Rank.Legendary);
            FantasticCreature gCreature = new FantasticCreature("그리핀", 50, FantasticCreature.Rank.Epic);
            FantasticCreature sCreature = new FantasticCreature("슬라임", 10, FantasticCreature.Rank.Rare);

            Unicorn unicorn = new Unicorn();

            while (true)
            {
                Console.Write("도감에서 찾으실 판타지 동물을 입력해주세요: ");
                string name = Console.ReadLine();


                if (name == dCreature.name)
                {
                    dCreature.CreatureGuide();
                    dCreature.Skill(name, "불 뿜기");
                    Console.WriteLine("");
                }

                else if (name == gCreature.name)
                {
                    gCreature.CreatureGuide();
                    gCreature.Skill(name, "날개 바람");
                    Console.WriteLine("");
                }

                else if (name == sCreature.name)
                {
                    sCreature.CreatureGuide();
                    sCreature.Skill(name, "박치기");
                    Console.WriteLine("");
                }

                else if (name == "종료")
                {
                    Console.WriteLine("프로그램이 종료되었습니다.");
                    break;
                }

                else if (name == "유니콘")
                {
                    unicorn.Fly(name);
                    unicorn.Skill(name, "뿔 찌르기");
                }
                else
                {
                    Console.WriteLine("도감에 없는 판타지 동물입니다.");
                    Console.WriteLine("");
                }
            }
        }
    }

}

