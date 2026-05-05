using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingCSharp
{
    internal class _0414
    {
        public interface IHello
        {
            void Hello();
        }

        public interface ICalculation
        {
            void Calc();
        }

        public interface ITakeCall
        {
            void TakeCall();
        }
        class Counter : IHello, ICalculation, ITakeCall
        {
            // step1 멤버 변수 3개 이상 추가
            private string m_name;
            private int m_money;
            public int Satisfaction { get; set; }
            public int Energy { get; private set; } // step 4  최종 폼으로 깔끔한 프로퍼티 사용해보기


            //=========================================================================
            // Step 2 해당 멤버 변수를 Get, Set 함수로 만들어보기 
            public string GetName()
            {
                return m_name;
            }

            public void SetName(string name)
            {
                m_name = name;
            }

            // ============================================================

            //==============================================================
            // step 3 프로퍼티의 get return,  set value 대입 사용해서 구현해보기

            public int Money
            {
                get { return m_money; }
                set
                {
                    if (m_money != value)
                    {
                        m_money = value;
                    }
                }
            }
            //==============================================================================

            public void InitChangeValue(string name, int money, int energy, int satisfaction)
            {
                SetName(name);
                m_money = money;
                Energy = energy;
                Satisfaction = satisfaction;
            }


            public void Hello()
            {
                Console.WriteLine($"안녕하세요 담당자 {m_name}입니다. ");

            }
            public void Calc()
            {
                Console.WriteLine($"총액은 {Money}입니다. 감사합니다.");
            }
            public void TakeCall()
            {
                Console.WriteLine($"전화가 왔네요 띠리리링");
                Console.WriteLine($"고객 만족도 {Satisfaction}점인 오렌지 회사입니다");

            }
            public void Smile()
            {
                Console.WriteLine("오늘 하루도 친절하게 모시겠습니다.");

            }
        }
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.InitChangeValue("오렌지", 100000, 100, 30); // 프로퍼티 값 수정 

            counter.TakeCall();
            counter.Hello();
            counter.Smile();
            counter.Calc();
            Console.WriteLine($"오늘은 체력이 {counter.Energy}정도 남은 거 같네요");
        }
    }
}
