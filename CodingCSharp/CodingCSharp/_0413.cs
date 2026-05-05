using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingCSharp
{
    internal class _0413
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
            public void Hello()
            {
                Console.WriteLine("카운터는 인사를 잘 해야한다.");
            }
            public void Calc()
            {
                Console.WriteLine("카운터는 계산을 잘 해야한다.");
            }
            public void TakeCall()
            {
                Console.WriteLine("카운터는 전화도 받아야한다.");
            }
            public void Smile()
            {
                Console.WriteLine("카운터는 친절해야한다.");

            }
        }
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.Hello();
            counter.Smile();
            counter.Calc();
            counter.TakeCall();
        }
    }
}
