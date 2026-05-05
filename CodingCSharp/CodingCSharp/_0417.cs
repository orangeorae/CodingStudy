using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingCSharp
{
    internal class _0417
    {
        public class CatManager
        {
            private static CatManager _instance;

            public static CatManager Inst
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new CatManager();
                    }
                    return _instance;
                }
            }

            public void Cat()
            {
                Console.WriteLine("고양이 호출");
            }

            private CatManager() { }
        }
        static void Main(string[] args)
        {
            CatManager.Inst.Cat();


        }

    }
}
