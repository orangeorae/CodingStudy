using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCSharp
{
    internal class _0415
    {
        public class Counter
        {
            public string m_name = "오렌지마트";
            public string m_food;

            public event Action<string> OnObject;
            public event Action<string, int> OnGive;

            public void Request(string food)
            {
                this.m_food = food;
                OnObject?.Invoke(m_name);
                Console.WriteLine($"[손님] {food} 좀 주세요 ");
            }

            public void Give(int money)
            {

                Console.WriteLine($"[손님] 얼마인가요?");
                OnGive?.Invoke(this.m_food, 1500);
            }
        }

        static void HelloAction(string name)
        {
            Console.WriteLine($"[직원] 안녕하세요 고객님 신선함을 전하는 {name} 입니다.");
        }

        static void Question(string name)
        {
            Console.WriteLine($"[직원] 어떤 물건이 필요하실까요?");
        }

        static void GiveAction(string food, int money)
        {
            Console.WriteLine($"[직원] 말씀하신 {food} 여기 있습니다. 가격은 {money}원 입니다. 오늘 하루도 좋은 하루 되세요");
        }
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.OnObject += HelloAction;
            counter.OnObject += Question;
            counter.Request("가지");


            counter.OnGive += GiveAction;
            counter.Give(1500);
        }
    }
}
