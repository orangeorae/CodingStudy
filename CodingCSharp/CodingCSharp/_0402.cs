using System;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Xml.Linq;
namespace OzCodingCSharp
{
    internal class _0402
    {
        class HandPhone
        {
            string m_name;
            public virtual void Ring(string name)
            {
                m_name = name;
                Console.WriteLine($"띠리링 {m_name}(이)에게 전화가 왔어요 ~~");
            }

            public void Camera(bool click)
            {

                if (click == true)
                {
                    Console.WriteLine($"카메라의 클릭 버튼을 눌렀어요 다들 찰칵(브이브이) ! ");
                }
                else if (click == false)
                {
                    Console.WriteLine("카메라의 클릭 버튼이 안눌렸어요 사진 안찍혀요");
                }
            }
        }

        class GalaxyPhone : HandPhone
        {
            public void Recording(int second)
            {
                Console.WriteLine($"녹음이 {second}초동안 되었어요 ");
            }

            public override void Ring(string name) // 오버라이드
            {
                base.Ring("강지");
                Console.WriteLine($"띠리링 {name}(이)에게 전화를 했어요 ~~");
            }
        }

        class ApplePhone : HandPhone
        {
            public void AirDrop(string name, string friend)
            {
                Console.WriteLine($"{name}(이)의 사진이 {friend}(이)한테 에어드랍으로 공유가 되었어요");
            }
        }

        static void Main(string[] args)
        {
            GalaxyPhone sam = new GalaxyPhone();
            ApplePhone ap = new ApplePhone();
            HandPhone p = new GalaxyPhone();
            sam.Ring("강지");
            Console.WriteLine($"\n");

            ap.Ring("고냥");
            Console.WriteLine($"\n");

            p.Ring("곰돌이"); //오버라이드
            Console.WriteLine($"\n");

            sam.Camera(true);  //부모 클래스 거 
            ap.Camera(false);

            Console.WriteLine($"\n");
            sam.Recording(30);
            ap.AirDrop("강지", "고냥");


        }
    }
}
