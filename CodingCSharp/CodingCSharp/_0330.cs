using System;

namespace CodingCSharp
{
    internal class _0330
    {
        static void Main(string[] args)
        {
            int add = 0; // 덧셈
            int sub = 0; // 뺄셈
            int mul = 0; // 곱셈
            int div = 0; //나눗셈

            string number;
            int playerNumber = 0;

            string first;
            int firstInt;

            string second;
            int secondInt;


            Console.WriteLine("====================계        산       기====================");
            Console.WriteLine("1.덧셈     2.뺄셈    3.곱셈    4.나눗셈");
            Console.Write("번호 입력: ");

            number = Console.ReadLine(); // 문자열만 반환되니까 문자열로 일단 받기
            Console.WriteLine();
            playerNumber = int.Parse(number); // 문자열로 반환된 값을 정수형으로 옮겨담기 

            if (playerNumber == 1)
            {
                Console.WriteLine("==========덧     셈     계     산     기==========");
                Console.WriteLine("덧셈을 하실 숫자를 입력해주세요: ");

                Console.Write("첫번째 숫자: ");
                first = Console.ReadLine();
                firstInt = int.Parse(first);

                Console.Write("두번째 숫자: ");
                second = Console.ReadLine();
                secondInt = int.Parse(second);
                Console.WriteLine();

                add = firstInt + secondInt;

                Console.WriteLine("==========계     산     중========== ");
                Console.WriteLine($"덧셈의 결과: {add} ");
            }

            else if (playerNumber == 2)
            {
                Console.WriteLine("==========뺄     셈     계     산     기==========");
                Console.WriteLine("뺄셈을 하실 숫자를 입력해주세요: ");

                Console.Write("첫번째 숫자: ");
                first = Console.ReadLine();
                firstInt = int.Parse(first);

                Console.Write("두번째 숫자: ");
                second = Console.ReadLine();
                secondInt = int.Parse(second);
                Console.WriteLine();
                sub = firstInt - secondInt;

                Console.WriteLine("==========계     산     중========== ");
                Console.WriteLine($"뺄셈의 결과: {sub} ");
            }

            else if (playerNumber == 3)
            {
                Console.WriteLine("==========곱     셈     계     산     기==========");
                Console.WriteLine("곱셈을 하실 숫자를 입력해주세요: ");

                Console.Write("첫번째 숫자: ");
                first = Console.ReadLine();
                firstInt = int.Parse(first);

                Console.Write("두번째 숫자: ");
                second = Console.ReadLine();
                secondInt = int.Parse(second);
                Console.WriteLine();
                mul = firstInt * secondInt;

                Console.WriteLine("==========계     산     중========== ");
                Console.WriteLine($"곱셈의 결과: {mul} ");
            }

            else if (playerNumber == 4)
            {
                Console.WriteLine("==========나     눗     셈     계     산     기==========");
                Console.WriteLine("나눗셈을 하실 숫자를 입력해주세요 ");

                Console.Write("첫번째 숫자: ");
                first = Console.ReadLine();
                firstInt = int.Parse(first);

                Console.Write("두번째 숫자: ");
                second = Console.ReadLine();
                secondInt = int.Parse(second);
                Console.WriteLine();
                div = firstInt / secondInt;

                Console.WriteLine("==========계     산     중========== ");
                Console.WriteLine($"나눗셈의 결과: {div} ");
            }

            else
            {
                Console.WriteLine("계산기에 없는 숫자입니다.");
            }
        }
    }
}
