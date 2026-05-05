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
    internal class _0407
    {
        class CoffeeMachine
        {
            public virtual void MakeCoffe(string firstCapsule, string secondCapsule)
            {
                string printCoffe = $"커피머신에 {firstCapsule}과(와) {secondCapsule}을 넣어 커피를 추출했습니다.";

                Console.WriteLine(printCoffe);
            }
        }

        class EspressoMachine : CoffeeMachine
        {
            public override void MakeCoffe(string firstCapsule, string secondCapsule)
            {
                string printCoffe = $"커피머신에 {firstCapsule}과(와) {secondCapsule}을 넣어 커피를 추출했습니다.";

                Console.WriteLine(printCoffe);
            }
        }

        class LatteMachine : CoffeeMachine
        {
            public override void MakeCoffe(string firstCapsule, string secondCapsule)
            {
                string printCoffe = $"커피머신에 {firstCapsule}과(와) {secondCapsule}을 넣어 커피를 추출했습니다.";

                Console.WriteLine(printCoffe);
            }
        }
        static void Main(string[] args)
        {
            List<CoffeeMachine> useCoffeMachine = new List<CoffeeMachine>();


            CoffeeMachine coffeMachine = new CoffeeMachine();
            EspressoMachine espressoMachine = new EspressoMachine();
            LatteMachine LatteMachine = new LatteMachine();
            useCoffeMachine.Add(coffeMachine);
            useCoffeMachine.Add(espressoMachine);
            useCoffeMachine.Add(LatteMachine);


            foreach (CoffeeMachine innerCapsule in useCoffeMachine)
            {
                if (innerCapsule == null)
                {
                    continue;
                }


                if (innerCapsule is EspressoMachine em)
                {
                    em.MakeCoffe("에스프레소 캡슐", "물");
                }
                else if (innerCapsule is LatteMachine lm)
                {
                    lm.MakeCoffe("에스프레소 캡슐", "우유");
                }

                else if (innerCapsule is CoffeeMachine cm)
                {
                    cm.MakeCoffe("에소프레소캡슐", "아이스티");
                }

            }

        }
    }

}

