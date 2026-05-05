using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodingCSharp
{
    internal class _0410
    {
        public class Furniture
        {
            public int id = 0;
            public string name;
            public string description;

            public Furniture(int id, string name, string description)
            {
                this.id = id;
                this.name = name;
                this.description = description;
            }
        }

        public class FurnitureStore
        {

            Dictionary<string, Furniture> m_TodayFurniture = new Dictionary<string, Furniture>();

            public void TodayGetFurniture()
            {
                m_TodayFurniture.Clear(); // 초기화

                Furniture f1 = new Furniture(101, "책상", "10만원");
                Furniture f2 = new Furniture(201, "의자", "5만원");
                Furniture f3 = new Furniture(301, "서랍장", "30만원");
                Furniture f4 = new Furniture(401, "옷장", "40만원");
                Furniture f5 = new Furniture(501, "책장", "20만원");
                Furniture f6 = new Furniture(601, "소파", "100만원");
                Furniture f7 = new Furniture(701, "침대", "200만원");
                Furniture f8 = new Furniture(801, "신발장", "10만원");
                Furniture f9 = new Furniture(901, "식탁", "40만원");
                Furniture f10 = new Furniture(1001, "화장대", "12만원");

                m_TodayFurniture.Add("책상", f1);
                m_TodayFurniture.Add("의자", f2);
                m_TodayFurniture.Add("서랍장", f3);
                m_TodayFurniture.Add("옷장", f4);
                m_TodayFurniture.Add("책장", f5);
                m_TodayFurniture.Add("소파", f6);
                m_TodayFurniture.Add("침대", f7);
                m_TodayFurniture.Add("신발장", f8);
                m_TodayFurniture.Add("식탁", f9);
                m_TodayFurniture.Add("화장대", f10);

            }

            public void OpenStore()
            {
                int count = 1;
                foreach (var furn in m_TodayFurniture)
                {

                    Console.WriteLine($"{count}.{furn.Key} / 가격: {furn.Value.description}");
                    count++;

                }
            }
        }
        static void Main(string[] args)
        {
            FurnitureStore store = new FurnitureStore();

            store.TodayGetFurniture();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("오늘의 가구 리스트");
            Console.WriteLine("===========================================================================");

            store.OpenStore();

        }
    }
}
