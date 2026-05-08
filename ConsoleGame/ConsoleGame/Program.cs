using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class Program
    {
        static List<string> ingredientsBox = new List<string>();
        public static int wallet;
        public static int price = 0;
        public static string CookFood;

        public static event Action OnGameClear;
        public static event Action OnGameOver;
        public static void Enter()
        {
            Console.Write(".....Enter");
            Console.ReadLine();
        }

        public static void ClearAddMessage()
        {
            Console.WriteLine("성공을 축하합니다. 다음에 또 다른 재밌는 게임으로 다시 뵙겠습니다.");
        }
        public static void GameOverAddMessage()
        {
            Console.WriteLine("다음에는 성공하시기를 바랍니다.");
        }
        interface IStory
        {
            void Story();
        }
        class StoryBase : IStory
        {
            public virtual void Story()
            {
                Console.WriteLine($"================================게     임     설     명==============================================");
                Console.WriteLine($"\n설명 :이 게임은 각 음식에 맞는 재료를 사서 집으로 가져가서 맛있는 요리가 완성되도록 하는 게임입니다.");
                Console.WriteLine($"\n상세 설명: 여러 요리중에 등장인물인 딸이 요리를 정하면 엄마가 요리 재료를 알려줍니다.");
                Console.WriteLine($"\n상세 설명: 마트로가서 장을 본 후 재료가 일치하면 게임 성공 재료가 일치하지 않으면 게임실패입니다.");
                Console.WriteLine("\n게임에서 성공하시기를 바라겠습니다. 화이팅!");
                Console.Write($"=====================================================================================================        ");
                Enter();

            }

        }
        class FirstStory : StoryBase
        {
            public override void Story()
            {
                Console.WriteLine("\n==========================================");
                Console.Write("               첫번째 스토리                    ");
                Console.WriteLine("\n==========================================");
                Console.Write("[엄마] 오늘 우리 딸이 먹고 싶은 거 만들어줄게 뭐가 먹고싶니?");
                Enter();
                while (true)
                {
                    Console.WriteLine("\n===============음    식===============");
                    Console.WriteLine("1. 제육볶음\n2. 된장찌개 \n3. 불고기 \n4. 닭볶음탕 \n5. 오징어볶음 \n6. 연어샐러드");
                    Console.WriteLine("======================================");
                    Console.Write("[System] 입력: ");
                    CookFood = Console.ReadLine();

                    if (CookFood == "제육볶음" || CookFood == "1")
                    {
                        if (CookFood == "1") CookFood = "제육볶음";

                        Console.Write($"[딸] {CookFood}을(를) 먹고싶어요 ! ");
                        Enter();
                        Console.Write($"\n[엄마] 우리 딸 {CookFood}이(가) 먹고 싶구나~ 엄마가 맛있게 해줄게  ");
                        Enter();
                        Console.Write($"[엄마]근데 냉장고에 {CookFood}의 재료인 돼지고기와 파가 없구나  ");
                        Enter();
                        Console.Write($"[엄마]우리 딸이 앞에 마트 가서 사올래? ");
                        Enter();

                        Console.Write($"\n[엄마]엄마가 50000원 줄게 !  ");
                        Enter();
                        wallet = 50000;

                        Console.Write($"\n[엄마]재료는 돼지고기, 파야 ! ");
                        Enter();
                        Console.Write($"[딸] 네 ! 금방 갔다올게요!");
                        Enter();
                        break;
                    }

                    else if (CookFood == "된장찌개" || CookFood == "2")
                    {
                        if (CookFood == "2") CookFood = "된장찌개";

                        Console.Write($"[딸] {CookFood}을(를) 먹고싶어요 ! ");
                        Enter();
                        Console.Write($"\n[엄마] 우리 딸 {CookFood}이(가) 먹고 싶구나~ 엄마가 맛있게 해줄게  ");
                        Enter();
                        Console.Write($"[엄마]근데 냉장고에 {CookFood}의 재료인 애호박, 양파, 두부가 없구나  ");
                        Enter();
                        Console.Write($"[엄마]우리 딸이 앞에 마트 가서 사올래? ");
                        Enter();
                        Console.Write($"\n[엄마]엄마가 50000원 줄게 !  ");
                        Enter();
                        wallet = 50000;
                        Console.Write($"\n[엄마]재료는 애호박, 양파, 두부야! ");
                        Enter();
                        Console.Write($"[딸] 네 ! 금방 갔다올게요!");
                        Enter();
                        break;
                    }

                    else if (CookFood == "불고기" || CookFood == "3")
                    {
                        if (CookFood == "3") CookFood = "불고기";

                        Console.Write($"[딸] {CookFood}을(를) 먹고싶어요 ! ");
                        Enter();
                        Console.Write($"\n[엄마] 우리 딸 {CookFood}이(가) 먹고 싶구나~ 엄마가 맛있게 해줄게  ");
                        Enter();
                        Console.Write($"[엄마]근데 냉장고에 {CookFood}의 재료인 소고기, 양파가 없구나  ");
                        Enter();
                        Console.Write($"[엄마]우리 딸이 앞에 마트 가서 사올래? ");
                        Enter();
                        Console.Write($"\n[엄마]엄마가 50000원 줄게 !  ");
                        Enter();
                        wallet = 50000;
                        Console.Write($"\n[엄마]재료는 소고기, 양파야! ");
                        Enter();
                        Console.Write($"[딸] 네 ! 금방 갔다올게요!");
                        Enter();
                        break;
                    }

                    else if (CookFood == "닭볶음탕" || CookFood == "4")
                    {
                        if (CookFood == "4") CookFood = "닭볶음탕";

                        Console.Write($"[딸] {CookFood}을(를) 먹고싶어요 ! ");
                        Enter();
                        Console.Write($"\n[엄마] 우리 딸 {CookFood}이(가) 먹고 싶구나~ 엄마가 맛있게 해줄게  ");
                        Enter();
                        Console.Write($"[엄마]근데 냉장고에 {CookFood}의 재료인 닭고기, 고구마, 양파, 파가  없구나  ");
                        Enter();
                        Console.Write($"[엄마]우리 딸이 앞에 마트 가서 사올래? ");
                        Enter();
                        Console.Write($"\n[엄마]엄마가 50000원 줄게 !  ");
                        Enter();
                        wallet = 50000;
                        Console.Write($"\n[엄마]재료는 닭고기, 고구마, 양파, 파야! ");
                        Enter();
                        Console.Write($"[딸] 네 ! 금방 갔다올게요!");
                        Enter();
                        break;
                    }

                    else if (CookFood == "오징어볶음" || CookFood == "5")
                    {
                        if (CookFood == "5") CookFood = "오징어볶음";

                        Console.Write($"[딸] {CookFood}을(를) 먹고싶어요 ! ");
                        Enter();
                        Console.Write($"\n[엄마] 우리 딸 {CookFood}이(가) 먹고 싶구나~ 엄마가 맛있게 해줄게  ");
                        Enter();
                        Console.Write($"[엄마]근데 냉장고에 {CookFood}의 재료인 오징어, 양배추, 양파가  없구나  ");
                        Enter();
                        Console.Write($"[엄마]우리 딸이 앞에 마트 가서 사올래? ");
                        Enter();
                        Console.Write($"\n[엄마]엄마가 50000원 줄게 !  ");
                        Enter();
                        wallet = 50000;
                        Console.Write($"\n[엄마]재료는 오징어, 양배추, 양파야! ");
                        Enter();
                        Console.Write($"[딸] 네 ! 금방 갔다올게요!");
                        Enter();
                        break;
                    }
                    else if (CookFood == "연어샐러드" || CookFood == "6")
                    {
                        if (CookFood == "6") CookFood = "연어샐러드";

                        Console.Write($"[딸] {CookFood}을(를) 먹고싶어요 ! ");
                        Enter();
                        Console.Write($"\n[엄마] 우리 딸 {CookFood}이(가) 먹고 싶구나~ 엄마가 맛있게 해줄게  ");
                        Enter();
                        Console.Write($"[엄마]근데 냉장고에 {CookFood}의 재료인 연어 양배추가  없구나  ");
                        Enter();
                        Console.Write($"[엄마]우리 딸이 앞에 마트 가서 사올래? ");
                        Enter();
                        Console.Write($"\n[엄마]엄마가 50000원 줄게 !  ");
                        Enter();
                        wallet = 50000;
                        Console.Write($"\n[엄마]재료는  연어, 양배추야! ");
                        Enter();
                        Console.Write($"[딸] 네 ! 금방 갔다올게요!");
                        Enter();
                        break;

                    }
                    else
                    {
                        Console.WriteLine($"[엄마] 딸 미안해 {CookFood}은 지금 만들어줄 수가 없어... 다른 걸 골라줄래?");
                    }
                }
            }


        }

        class SecondStory : StoryBase
        {
            public string Name { get; private set; }

            public SecondStory(string name)
            {
                Name = name;
            }
            public override void Story()
            {
                string department;
                string ingredients;

                Console.Clear();

                Console.WriteLine("==========================================");
                Console.WriteLine("               두번째 스토리                    ");
                Console.WriteLine("==========================================");
                Console.Write("\n[System] 뚜벅.... 뚜벅....  마트로 걸어갑니다. ");
                Enter();
                Console.Write($"[계산원] 어세오세요 ~!  {Name}마트입니다! ");
                Enter();
                Console.WriteLine("\n[딸] 마트에 도착했다..  엄마가 사오라 했던 재료를 기억해서 알맞게 사가자! ");
                Console.Write($"[딸] 내가 가지고 있는 {wallet}원 안에서 알뜰하게 사야겠어! ");
                Enter();
                while (true)
                {
                    Console.WriteLine("[딸] 어떤 코너를 갈까? ");
                    Console.WriteLine("\n===============마트 코너===============");
                    Console.WriteLine("1. 야채코너\n2. 식품코너 \n3. 정육코너 \n4. 수산코너 \n5. 계산하러 간다.");
                    Console.WriteLine("========================================");
                    Console.Write("[System] 입력: ");
                    department = Console.ReadLine();

                    if (department == "야채코너" || department == "1")
                    {
                        if (department == "1") department = "야채코너";

                        Console.WriteLine("\n[System] 뚜벅.... 뚜벅..... ");
                        Console.Write($"\n[System] {department}에 도착했습니다 ");
                        while (true)
                        {

                            Console.Write($"\n[System] 어떤 것을 고르시겠습니까? ");

                            Console.WriteLine($"\n==============={department}===============");
                            Console.WriteLine("1. 양파/1980원\n2. 파/1980원 \n3. 고구마/3460원\n4. 애호박/2980원 \n5. 양배추/2500원 \n6. 떠나기");
                            Console.WriteLine("========================================");
                            Console.Write("[System] 입력: ");
                            ingredients = Console.ReadLine();
                            if (ingredients == "양파" || ingredients == "1")
                            {
                                if (ingredients == "1") ingredients = "양파";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "파" || ingredients == "2")
                            {
                                if (ingredients == "2") ingredients = "파";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "고구마" || ingredients == "3")
                            {
                                if (ingredients == "3") ingredients = "고구마";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "애호박" || ingredients == "4")
                            {
                                if (ingredients == "4") ingredients = "애호박";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "양배추" || ingredients == "5")
                            {
                                if (ingredients == "5") ingredients = "양배추";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }

                            else if (ingredients == "떠나기" || ingredients == "6")
                            {

                                Console.WriteLine($"\n===============장  바  구  니====================");
                                for (int i = 0; i < ingredientsBox.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{ingredientsBox[i]}\n");
                                }
                                Console.WriteLine("=================================================");
                                break;
                            }
                        }
                    }

                    else if (department == "식품코너" || department == "2")
                    {
                        if (department == "2") department = "식품코너";

                        Console.WriteLine("\n[System] 뚜벅.... 뚜벅..... ");
                        Console.Write($"\n[System] {department}에 도착했습니다 ");
                        while (true)
                        {
                            Console.Write($"\n[System] 어떤 것을 고르시겠습니까? ");
                            Console.WriteLine($"\n==============={department}===============");
                            Console.WriteLine("1. 두부/990원 \n2. 떠나기");
                            Console.WriteLine("=============================================");
                            Console.Write("[System] 입력: ");
                            ingredients = Console.ReadLine();

                            if (ingredients == "두부" || ingredients == "1")
                            {
                                if (ingredients == "1") ingredients = "두부";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }

                            else if (ingredients == "떠나기" || ingredients == "2")
                            {

                                Console.WriteLine($"\n===============장  바  구  니====================");
                                for (int i = 0; i < ingredientsBox.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{ingredientsBox[i]}\n");
                                }
                                Console.WriteLine("=================================================");
                                break;
                            }
                        }
                    }

                    else if (department == "정육코너" || department == "3")
                    {
                        if (department == "3") department = "정육코너";

                        Console.WriteLine("\n[System] 뚜벅.... 뚜벅..... ");
                        Console.Write($"\n[System] {department}에 도착했습니다 ");
                        while (true)
                        {
                            Console.Write($"\n[System] 어떤 것을 고르시겠습니까? ");

                            Console.WriteLine($"\n==============={department}===============");
                            Console.WriteLine("1. 돼지고기/20000원 \n2. 소고기/35000원 \n3. 닭고기/13000원 \n4. 떠나기");
                            Console.WriteLine("=============================================");
                            Console.Write("[System] 입력: ");
                            ingredients = Console.ReadLine();
                            if (ingredients == "돼지고기" || ingredients == "1")
                            {
                                if (ingredients == "1") ingredients = "돼지고기";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "소고기" || ingredients == "2")
                            {
                                if (ingredients == "2") ingredients = "소고기";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "닭고기" || ingredients == "3")
                            {
                                if (ingredients == "3") ingredients = "닭고기";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "떠나기" || ingredients == "4")
                            {
                                Console.WriteLine($"\n===============장  바  구  니====================");
                                for (int i = 0; i < ingredientsBox.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{ingredientsBox[i]}\n");
                                }
                                Console.WriteLine("=================================================");
                                break;
                            }

                        }
                    }

                    else if (department == "수산코너" || department == "4")
                    {
                        if (department == "4") department = "수산코너";

                        Console.WriteLine("\n[System] 뚜벅.... 뚜벅..... ");
                        Console.Write($"\n[System] {department}에 도착했습니다 ");
                        while (true)
                        {
                            Console.Write($"\n[System] 어떤 것을 고르시겠습니까? ");

                            Console.WriteLine($"\n==============={department}===============");
                            Console.WriteLine("1. 오징어/13000원 \n2. 연어/18000원 \n3. 떠나기");
                            Console.WriteLine("=============================================");
                            Console.Write("[System] 입력: ");
                            ingredients = Console.ReadLine();

                            if (ingredients == "오징어" || ingredients == "1")
                            {
                                if (ingredients == "1") ingredients = "오징어";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "연어" || ingredients == "2")
                            {
                                if (ingredients == "2") ingredients = "연어";

                                ingredientsBox.Add(ingredients);
                                Console.WriteLine($"\n[System] 장바구니에 {ingredients}를 담았습니다.");
                            }
                            else if (ingredients == "떠나기" || ingredients == "3")
                            {

                                Console.WriteLine($"\n===============장  바  구  니====================");
                                for (int i = 0; i < ingredientsBox.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}.{ingredientsBox[i]}\n");
                                }
                                Console.WriteLine("=============================================");
                                break;
                            }
                        }
                    }

                    else if (department == "계산하러 간다" || department == "5")
                    {
                        Console.WriteLine("[딸] 물건을 다 산 거 같아! 이제 계산하러 가야겠어!");
                        break;
                    }
                }

            }

        }

        class ThirdStory : StoryBase
        {
            int totalPrice;
            public override void Story()
            {

                Dictionary<string, int> ingredientsPrice = new Dictionary<string, int>()
                {
                    { "양파", 1980},
                    { "파", 1980},
                    {"고구마", 3460},
                    {"애호박", 2980 },
                    {"양배추", 2500 },
                    {"두부", 990 },
                    {"돼지고기",20000 },
                    {"소고기", 35000},
                    {"닭고기", 13000 },
                    {"오징어", 13000 },
                    { "연어", 18000}

                };
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("               세번째 스토리                    ");
                Console.WriteLine("==========================================");
                Console.Write("[System] 뚜벅.... 뚜벅.... 장바구니를 흔들며 카운터에 도착했다.");
                Enter();
                Console.Write("\n[계산원] 안녕하세요 ~ 계산 도와드리겠습니다!");
                Enter();
                Console.WriteLine("\n[System] 장바구니에서 물건을 꺼낸다.");

                foreach (string basket in ingredientsBox)
                {
                    Console.Write($"\n[딸] {basket}을 꺼냈습니다. ");
                    Enter();

                    if (ingredientsPrice.ContainsKey(basket))//재료가 있으면
                    {
                        price = ingredientsPrice[basket];
                        Console.WriteLine($"[카운터] 삑 {basket}의 가격은 {price}입니다\n\n");
                        totalPrice = totalPrice + price;


                    }
                }
                Console.Write($"[계산원] 총액은 {totalPrice}입니다!");
                Enter();
                Console.Write($"\n[딸] 여기 {wallet} 원이요!");
                Enter();
                Console.WriteLine($"\n[계산원] 네 ~  50000원 받았습니다 ~");
                wallet = wallet - totalPrice;
                if (wallet > 0)
                {
                    Console.Write($"[계산원] 여기 거스름돈 {wallet} 입니다! 감사합니다 ");
                    Enter();
                    Console.Write($"\n[딸] 감사합니다 ! 안녕히계세요! ");
                    Enter();
                    Console.WriteLine($"\n[계산원] 안녕히가세요~! ");
                    Console.Write($"\n[System] 마트를 나왔다.");
                    Enter();
                    Console.Write($"[딸] 이제 장도 다 봤고 집으로 돌아가야지!! ");
                    Enter();
                    Console.Write($"[딸] 엄마가 기다리고 계시겠다. 얼른가야겠어 ");
                    Enter();
                }

                else if (wallet == 0)
                {
                    Console.Write($"[계산원] 계산 완료 되었습니다. 감사합니다! ");
                    Enter();
                    Console.Write($"[딸] 감사합니다 ! 안녕히계세요! ");
                    Enter();
                    Console.WriteLine($"[계산원] 안녕히가세요~! ");
                    Console.Write($"[System] 마트를 나왔다.");
                    Enter();
                    Console.Write($"[딸] 이제 장도 다 봤고 집으로 돌아가야지!! ");
                    Enter();
                    Console.Write($"[딸] 엄마가 기다리고 계시겠다. 얼른가야겠어 ");
                    Enter();
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine($"\n[계산원] 돈이 부족하세요! ");
                        Console.Write($"\n[계산원] 물건을 장바구니에서 빼시겠습니까? ");
                        Console.WriteLine($"\n===============장  바  구  니====================");
                        for (int i = 0; i < ingredientsBox.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{ingredientsBox[i]}\n");
                        }
                        Console.WriteLine("=================================================");

                        Console.Write($"[딸] 헉 죄송합니다 ..  잠시만요.. ");
                        Enter();
                        Console.Write($"\n[System] 입력: ");
                        string removeItem = Console.ReadLine();
                        Console.WriteLine($"[딸] {removeItem} 빼겠습니다.");

                        if (!ingredientsBox.Contains(removeItem))
                        {
                            Console.WriteLine($"[System] 장바구니에 없는 물건입니다!.");
                            continue;
                        }

                        ingredientsBox.Remove(removeItem);
                        totalPrice = totalPrice - ingredientsPrice[removeItem];
                        wallet = 50000 - totalPrice;

                        Console.WriteLine($"[계산원] 현재 총 가격은 {totalPrice} 입니다. ");
                        //Console.WriteLine($"Log {wallet} ");

                        if (wallet > 0)
                        {
                            Console.Write($"[계산원] 여기 거스름돈 {wallet} 입니다! 감사합니다 ");
                            Enter();
                            Console.Write($"\n[딸] 감사합니다 ! 안녕히계세요! ");
                            Enter();
                            Console.WriteLine($"\n[계산원] 안녕히가세요~! ");
                            Console.Write($"\n[System] 마트를 나왔다.");
                            Enter();
                            Console.Write($"[딸] 이제 장도 다 봤고 집으로 돌아가야지!! ");
                            Enter();
                            Console.Write($"[딸] 엄마가 기다리고 계시겠다. 얼른가야겠어 ");
                            Enter();
                            break;
                        }

                        else if (wallet == 0)
                        {
                            Console.Write($"[계산원] 계산 완료 되었습니다. 감사합니다! ");
                            Enter();
                            Console.Write($"\n[딸] 감사합니다 ! 안녕히계세요! ");
                            Enter();
                            Console.WriteLine($"\n[계산원] 안녕히가세요~! ");
                            Console.Write($"\n[System] 마트를 나왔다.");
                            Enter();
                            Console.Write($"[딸] 이제 장도 다 봤고 집으로 돌아가야지!! ");
                            Enter();
                            Console.Write($"[딸] 엄마가 기다리고 계시겠다. 얼른가야겠어 ");
                            Enter();
                            break;
                        }

                        else
                        {
                            continue;
                        }

                    }
                }
            }
        }
        class FinalStory : StoryBase
        {

            public void ClearMent()
            {
                Console.WriteLine($"[엄마] 재료를 알맞게 잘 사왔네 우리 딸 ~");
                Console.Write($"[엄마] 엄마가 {CookFood} 맛있게 해줄게 !! ");
                Enter();

                Console.WriteLine($"\n\n=============================C     L     E     A     R=============================================== ");
                Console.WriteLine($"                                                                                                                                                                                                                    ");
                Console.WriteLine($"축하드립니다! 재료를 알맞게 사와 다같이 맛있는 밥을 먹었습니다!                                                                                                          ");
                Console.WriteLine($"                                                                                                                                                                                                                    ");
                Console.WriteLine($"==============================================================================================================");

                OnGameClear?.Invoke();
            }
            public void GameOverMent()
            {
                Console.Write($"[엄마] 빠진 재료가 있는데? 이걸로는 {CookFood}를 만들 수 없어!!");
                Enter();
                Console.WriteLine($"\n\n==========================G     A     M     E          O     V     E     R=====================================");
                Console.WriteLine($"                                                                                                                                                                                                                    ");
                Console.WriteLine($" 실패하였습니다. 재료가 부족하여 맛있는 밥을 먹지 못했습니다.                                                                                                               ");
                Console.WriteLine($"                                                                                                                                                                                                                    ");
                Console.WriteLine($"==============================================================================================================");
                OnGameOver?.Invoke();
            }

            public override void Story()
            {
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("               마지막 스토리                    ");
                Console.WriteLine("==========================================");
                Console.WriteLine("[System]뚜벅 뚜벅..  집에 도착했다. ");
                Console.Write("\n[딸]엄마! 저 왔어요!  ");
                Enter();
                Console.Write($"\n[엄마] 수고했어 우리 딸 ~ {CookFood}의 재료는 잘 사왔나 볼까? ");
                Enter();
                Console.WriteLine("\n[System] 딸이 장바구니를 엄마한테 보여준다.  ");

                Console.WriteLine($"\n===============장  바  구  니====================");
                for (int i = 0; i < ingredientsBox.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{ingredientsBox[i]}\n");
                }
                Console.WriteLine("=================================================");

                if (CookFood == "제육볶음")
                {
                    bool item_1 = ingredientsBox.Contains("돼지고기");
                    bool item_2 = ingredientsBox.Contains("파");

                    if (item_1 && item_2) ClearMent();
                    else GameOverMent();
                }

                else if (CookFood == "된장찌개")
                {
                    bool item_1 = ingredientsBox.Contains("두부");
                    bool item_2 = ingredientsBox.Contains("양파");
                    bool item_3 = ingredientsBox.Contains("애호박");

                    if (item_1 && item_2 && item_3) ClearMent();
                    else GameOverMent();
                }

                else if (CookFood == "불고기")
                {
                    bool item_1 = ingredientsBox.Contains("소고기");
                    bool item_2 = ingredientsBox.Contains("양파");

                    if (item_1 && item_2) ClearMent();
                    else GameOverMent();
                }

                else if (CookFood == "닭볶음탕")
                {
                    bool item_1 = ingredientsBox.Contains("닭고기");
                    bool item_2 = ingredientsBox.Contains("고구마");
                    bool item_3 = ingredientsBox.Contains("양파");
                    bool item_4 = ingredientsBox.Contains("파");

                    if (item_1 && item_2 && item_3 && item_4) ClearMent();
                    else GameOverMent();
                }
                else if (CookFood == "오징어볶음")
                {
                    bool item_1 = ingredientsBox.Contains("오징어");
                    bool item_2 = ingredientsBox.Contains("양배추");
                    bool item_3 = ingredientsBox.Contains("양파");


                    if (item_1 && item_2 && item_3) ClearMent();
                    else GameOverMent();
                }
                else if (CookFood == "연어샐러드")
                {
                    bool item_1 = ingredientsBox.Contains("연어");
                    bool item_2 = ingredientsBox.Contains("양배추");


                    if (item_1 && item_2) ClearMent();
                    else GameOverMent();
                }
            }
        }

        static void Main(string[] args)
        {
            OnGameClear += ClearAddMessage;
            OnGameOver += GameOverAddMessage;
            StoryBase basicStory = new StoryBase();
            FirstStory first = new FirstStory();
            SecondStory second = new SecondStory("오렌지");
            ThirdStory third = new ThirdStory();
            FinalStory final = new FinalStory();
            basicStory.Story();
            first.Story();
            second.Story();
            third.Story();
            final.Story();

        }

    }
}

