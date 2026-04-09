using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CodingCSharp
{
    public class Cashier
    {
        public string m_name;
        public int m_money;

        public Cashier(string name, int money)
        {
            this.m_name = name;
            this.m_money = money;
        }

        public void Wallet(Customer buyer, int price)
        {
            buyer.m_money = buyer.m_money - price;
            this.m_money = this.m_money + price;
        }

        public int porkBelly(int pigGram)
        {
            int gram = 1980;
            int price = pigGram * gram / 100;
            return price;
        }

        public int porkCollar(int pigGram)
        {
            int gram = 2080;
            int price = pigGram * gram / 100;
            return price;
        }
    }

    public class Customer
    {
        public string m_name;
        public int m_money;
        public Customer(string name, int money)
        {
            this.m_name = name;
            this.m_money = money;
        }

    }
    internal class _0331
    {
        public static void story()
        {
            Console.Write("[계산원]: 어서오세요! ");
            wait();
            Console.Write("[손님]: 안녕하세요!");
            wait();
            Console.Write("[계산원]: 어떤 게 필요하실까요? ");
            wait();
            Console.Write("[손님]: 고기를 조금 사고싶어요! ");
            wait();
            Console.Write("[계산원]: 고기는 돼지고기가준비되어 있습니다. ");
            wait();
            Console.Write($"[계산원]:  삼겹살, 목살 중 어느부위가 필요하십니까? ");
            wait();

        }

        public static void wait()
        {
            Console.Write("..........(Enter)");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            Cashier counter = new Cashier("계산원", 200000);
            Customer user = new Customer("손님", 100000);

            string meatName;
            int gram;
            int totalPrice;

            story();
            Console.Write("입력: ");
            meatName = Console.ReadLine();

            if (meatName == "삼겹살")
            {
                Console.Write($"[{counter.m_name}]: 몇그램 필요하십니까? ");
                wait();

                Console.Write("입력: ");

                gram = int.Parse(Console.ReadLine());
                totalPrice = counter.porkBelly(gram);
                Console.Write($"[{counter.m_name}]: {gram}g 가격은 {totalPrice}원 입니다!");
                wait();
                Console.Write($"[손님]: 여기  {totalPrice}입니다. ");
                wait();
                counter.Wallet(user, totalPrice);
                Console.Write($"[계산원]: 감사합니다. 안녕히가세요!.");
                wait();
                Console.Write($"[계산원]: 오예 이제 {counter.m_money}원 있다 ~~");
                wait();
                Console.Write($"[손님]: 이제  {user.m_money}원 밖에 없네 ... ");
                wait();
            }

            else if (meatName == "목살")
            {
                Console.Write($"[{counter.m_name}]: 몇그램 필요하십니까? ");
                wait();

                Console.Write("입력: ");

                gram = int.Parse(Console.ReadLine());
                totalPrice = counter.porkCollar(gram);
                Console.Write($"[{counter.m_name}]: {gram}g 가격은 {totalPrice}원 입니다!");
                wait();
                Console.Write($"[손님]: 여기  {totalPrice}입니다. ");
                wait();
                counter.Wallet(user, totalPrice);
                Console.Write($"[계산원]: 감사합니다. 안녕히가세요!.");
                wait();
                Console.Write($"[계산원]: 오예 이제 {counter.m_money}원 있다 ~~");
                wait();
                Console.Write($"[손님]: 이제  {user.m_money}원 밖에 없네 ... ");
                wait();

            }
        }
    }
}
