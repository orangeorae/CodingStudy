using System;
namespace CodingCSharp
{
    class User
    {
        public string m_name;
        public int m_love; // 호감도
        public int m_energy = 100; // 에너지

        public void UserName()
        {
            Console.Write("나의 이름을 입력해주세요: ");
            m_name = Console.ReadLine();
            Console.Write($"내이름 {m_name}(이)야 앞으로 잘 부탁해!");
            _0401.Wait();
            Console.Write($"내 이름을 알려줬더니 알이 반응을 해줬다. 나의 호감도가 올랐다. ");
            _0401.Wait();
            m_love = m_love + 10;

        }
        public void UserStatusWindow()
        {
            Console.WriteLine("===============사     용     자     상          태          창===============");
            Console.WriteLine($"이름: {m_name}");
            Console.WriteLine($"호감도: {m_love}");
            Console.WriteLine($"에너지: {m_energy}");
            Console.WriteLine("========================================================");
        }
    }

    class Dragon //드래곤의 상태
    {
        public String m_name;
        public int m_clean = 50; //청결도
        public int m_love = 0; //호감도

        public void DragonName(User user)
        {
            Console.WriteLine("==============================");
            Console.Write("드래곤의 이름을 입력해주세요: ");
            m_name = Console.ReadLine();
            Console.Write($"너의 이름은 {m_name}으로 정했어!");
            _0401.Wait();
            m_love = m_love + 10;
            Console.Write($"{user.m_name}(이)가 이름을 정해줘서 {m_name}의 호감도가 올랐다. ");
            _0401.Wait();
            Console.Write("서로 통성명이 끝났다.");
            _0401.Wait();

        }

        public void DragonStatusWindow()
        {
            Console.WriteLine("===============드     래     곤     상          태          창===============");
            Console.WriteLine($"이름: {m_name}");
            Console.WriteLine($"청결도: {m_clean}");
            Console.WriteLine($"호감도: {m_love}");
            Console.WriteLine("========================================================");
        }
    }
    internal class _0401
    {
        public static void MainStory(Dragon dragon, User user)
        {
            Console.WriteLine("나는 이제 뭐를 할까?");
            Console.WriteLine("==============================");
            Console.WriteLine($"1. 이뻐하기 2. 닦아주기 3. 말걸기 4. 나의 상태창 보기 5.{dragon.m_name}의 상태창 보기 ");
            Console.Write("입력: ");
            int workNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================");

            if (workNumber == 1)
            {
                Console.WriteLine($"나는 {dragon.m_name}(을)를 \"아이 이뻐라\" 해줬다.");
                Console.Write($"{dragon.m_name}(이)가 꿈틀 꿈틀 거리며 반응을 해줬다.");
                _0401.Wait();
                Console.WriteLine($"\n{dragon.m_name}의 호감도가 20 올라갔다.");
                Console.WriteLine($"{dragon.m_name}의 청결도가 20 내려갔다.");
                Console.WriteLine($"{user.m_name}의 에너지가 10 올라갔다.");
                Console.WriteLine($"{user.m_name}의 호감도가 20 올라갔다.\n");

                dragon.m_love += 20;
                user.m_energy += 10;
                dragon.m_clean -= 20;
                user.m_love += 20;
            }

            else if (workNumber == 2)
            {
                Console.WriteLine($"나는 {dragon.m_name}(을)를 깨끗하게 닦아 줬다 ");
                Console.Write($"{dragon.m_name}(이)가 꿈틀 꿈틀 거리며 반응을 해줬다.");
                _0401.Wait();
                Console.WriteLine($"\n{dragon.m_name}의 호감도가 30 올라갔다.");
                Console.WriteLine($"{dragon.m_name}의 청결도가 30 올라갔다.");
                Console.WriteLine($"{user.m_name}의 에너지가 30 내려갔다.");
                Console.WriteLine($"{user.m_name}의 호감도가 20 올라갔다.\n");

                dragon.m_love += 30;
                user.m_energy -= 30;
                dragon.m_clean += 30;
                user.m_love += 20;
            }

            else if (workNumber == 3)
            {
                Console.WriteLine($"나는 {dragon.m_name}에게 사랑한다고 말을 걸었다. ");
                Console.Write($"{dragon.m_name}(이)가 꿈틀 꿈틀 거리며 반응을 해줬다.");
                _0401.Wait();
                Console.WriteLine($"\n{dragon.m_name}의 호감도가 20 올라갔다.");
                Console.WriteLine($"{dragon.m_name}의 청결도가 20 내려갔다.");
                Console.WriteLine($"{user.m_name}의 에너지가 10 올라갔다.");
                Console.WriteLine($"{user.m_name}의 호감도가 20 올라갔다.\n");

                dragon.m_love += 20;
                user.m_energy += 10;
                dragon.m_clean -= 20;
                user.m_love += 20;
            }
            else if (workNumber == 4)
            {
                user.UserStatusWindow();
            }
            else if (workNumber == 5)
            {
                dragon.DragonStatusWindow();
            }

            if (dragon.m_love >= 100 && user.m_love >= 100)
            {
                Console.WriteLine("\n\n\n==========================================");
                Console.Write($"나의 호감도가 100을 채웠고 {dragon.m_name}의 호감도도 100을 채웠다");
                _0401.Wait();
                Console.Write($"{dragon.m_name}이 꿈틀거리며 깨지기 시작한다.");
                _0401.Wait();
                Console.WriteLine($"To be Continue... ");
                Console.WriteLine("==========================================\n\n");

                return;
            }
            if (dragon.m_clean <= 0)
            {
                Console.WriteLine("\n\n\n==========================================");
                Console.WriteLine("알이 점점 검은색이 되어가며 부화할 수 없는 상태가 되어버렸다.");
                Console.WriteLine("==========G   A   M   E          O   V   E   R==========");
            }
            if (user.m_energy <= 0 )
            {
                Console.WriteLine("\n\n\n==========================================");
                Console.WriteLine("에너지가 다 떨어져서 쓰러져버렸습니다.");
                Console.WriteLine("==========G   A   M   E          O   V   E   R==========");
            }
        }

        public static void Story()
        {
            Console.Write("어느 아침 다른 날들과 다를 바 없는 평범한 날이었다");
            Wait();
            Console.Write("아침에 일어나서 거실에 나가 티비를 켰다.");
            Wait();
            Console.Write("티비를 켰더니 상상의 동물 드래곤의 과거 흔적들이 나왔다는 내용으로 방송을 하고 있었다.");
            Wait();
            Console.Write("드래곤에 관심이 많던 나는 \"아 드래곤 만나보고싶다\" 라는 생각을 가졌다");
            Wait();
            Console.Write("그 후 나는 밥을 먹고 산책을 하러 나왔다.");
            Wait();
            Console.WriteLine("==============================");
            Console.WriteLine("산   책   하   러   가   는   길");
            Console.Write("==============================");
            Wait();
            Console.Write("어떤 길로 가시겠습니까?");
            Wait();
            Console.WriteLine("\n1.나무들과 풀들이 가득한 길  2. 차가 많고 도시스러운 길 ");
        }

        public static void ExStory()
        {
            Console.Write("\n차가 너무 많고 시끄럽군...");
            Wait();
            Console.Write("다시 집으로 돌아가서 드래곤 그림이나 그려야지");
            Wait();
            Console.Write("드래곤 만나보고싶군.....");
            Wait();
            Console.Write("==========[END]==========");
        }

        public static void FirstStory()
        {
            Console.Write("\n뚜벅 뚜벅.......");
            Wait();
            Console.Write("나무들도 많고 풀냄새도 좋고 힐링된다 ..");
            Wait();
            Console.Write("뚜벅... 뚜벅.....");
            Wait();
            Console.Write("엇...?? 으아아아아아아아악!");

            Wait();
            Console.Write("꽈다다다다당... 데구르르르");
            Wait();
            Console.Write("너무 아파,,,,,, 여기가 어디지..?");
            Wait();
            Console.Write("깜깜하고 무서워,,,,,,,");
            Wait();
            Console.Write("저기에 한줄기 빛이 보인다.... ");
            Wait();
            Console.Write("뚜벅.... 뚜벅..... ");
            Wait();
            Console.Write("헉 뭐야 드래곤 알이다 !!!!! ");
            Wait();
            Console.Write("드래곤 알을 조심히 만져본다");
            Wait();
            Console.Write("갑자기 드래곤알이 꿈틀거리기 시작한다. ");
            Wait();
            Console.Write("자기를 데려가라는 듯이 드래곤 알이 꿈틀거린다 ");
            Wait();
            Console.Write("나도 모르게 드래곤알을 품안에 안았다... ");
            Wait();
            Console.Write("따뜻한 드래곤알의 온기에 서서히 눈이 감긴다...");
            Wait();
            Console.Write("몇시간이 흐른 후....");
            Wait();
            Console.Write("눈 떠보니 아까 있던 산책길이다..!");
            Wait();
            Console.Write("한손에는 드래곤 알이 있다... ");
            Wait();
            Console.Write("얼른 집에 가야겠어 ! 뚜벅.. 뚜벅.. ");
            Wait();
            Console.Write("집에 도착했다..  내 방에 드래곤의 알을 나뒀다 ");
            Wait();
            Console.Write("드래곤에게 이름을 지어주고 싶다 그 전에 내 이름은 뭘로 할까? ");
            Wait();
            Console.Write("======================================================== ");
            Console.WriteLine();
        }

        public static void Wait()
        {
            Console.Write(".......(Enter)");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            User user = new User();
            Dragon dragon = new Dragon();

            Story();

            Console.Write("\n입력(숫자만 입력해주세요):");
            int walkNumber = int.Parse(Console.ReadLine());

            if (walkNumber == 1)
            {
                FirstStory();
                user.UserName();
                dragon.DragonName(user);
                while (true)
                {
                    MainStory(dragon, user);
                    if (dragon.m_love >= 100 && user.m_love >= 100 && dragon.m_clean > 0)
                    {
                        break;
                    }
                    else if (dragon.m_clean <= 0)
                    {
                        break;
                    }
                    else if (user.m_energy <= 0)
                    {
                        break;
                    }
                }
            }
            else if (walkNumber == 2)
            {
                ExStory();
            }
        }
    }
}
