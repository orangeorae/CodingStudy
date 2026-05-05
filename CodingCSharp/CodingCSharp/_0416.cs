using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CodingCSharp
{
    internal class _0416
    {
        static int number;

        public static void OrderFood(string message, Action<int> onFood)
        {

            Console.WriteLine($"[알림]{message}");
            Console.WriteLine($"어떤 행동을 하시겠습니까?");
            Console.WriteLine($"1. 바로 가서 음식을 가져온다 2. 10분뒤에 음식을 가져온다");
            number = int.Parse(Console.ReadLine());

            onFood?.Invoke(number);


        }

        public static void Wait(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("음식이 엄청 따뜻합니다. 맛있게 먹겠습니다.");
            }

            else if (number == 2)
            {
                Console.WriteLine("음식이 식었습니다. 간이 배어 더 맛있어졌습니다.");
            }
        }

        public static void AfterOrder(int number)
        {
            Console.WriteLine("맛있게 드셨으면 후기를 남겨주세요");
        }
        static void Main(string[] args)
        {

            Action<int> action = Wait;
            action += AfterOrder;
            OrderFood("배달이 도착했습니다.", action);
        }
    }
}