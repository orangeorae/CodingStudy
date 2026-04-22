using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace CodingCSharp
{

    class Employee // 직원
    {
        public void Name(string name)
        {
            Console.WriteLine($"나의 이름은 {name} 입니다.");
        }

        public virtual void Salary(int money)
        {
            Console.WriteLine($"나는 월급을 {money} 받는다.");
        }

        public void WorkTime(int time)
        {
            Console.WriteLine($"나는 하루에 {time}시간을 일한다");
        }
    }

    class Permanent : Employee //정규직
    {
        enum JobLevel
        {
            None = 0,
            freshMan = 300, // 신입사원
            Assistant = 400, // 대리
            Senior = 500// 과장
        }

        public void Job(int money)
        {
            JobLevel level;
            if (money >= 300 && money < 400)
            {
                level = JobLevel.freshMan;
            }

            else if (money >= 400 && money < 500)
            {
                level = JobLevel.Assistant;
            }

            else if (money >= 500)
            {
                level = JobLevel.Senior;
            }
            else
                level = JobLevel.None;

            Console.WriteLine($"당신의 직급은 {level}이신가 보네요?");
        }
    }

    class Contract : Employee//계약직
    {
        public void Renewal(int time)
        {
            int m_time = time;
            bool renewal;
            if (time >= 8)
            {
                renewal = true;
            }
            else
            {
                renewal = false;
            }

            if (renewal == true)
            {
                Console.WriteLine("재계약에 성공하셨어요 ! 정말 축하드려요 !!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("안타깝지만 재계약이 어려울 거 같습니다. 죄송합니다");
            }
        }

        public override void Salary(int money) //오버라이드
        {
            Console.WriteLine($"나는 너가 재계약에 성공하면 월급을 {money} 만원을 줄 것이다.");
        }
    }
    internal class _0403
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            Permanent per = new Permanent();
            Contract Con = new Contract();

            Console.WriteLine("당신의 이름은 어떻게 되시나요?");
            emp.Name("최개발");
            Console.WriteLine(" ");

            Console.WriteLine("너는 월급을 얼마를 받니?");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            per.Salary(money);
            per.Job(money);
            Console.WriteLine(" ");

            Console.WriteLine("당신의 하루에 몇시간 일하시나요? ");
            int time = int.Parse(Console.ReadLine());
            Con.WorkTime(time);
            Con.Renewal(time);

            Console.WriteLine(" ");
            Con.Salary(money + 100); //오버라이드

            //클래스 형변환
            Console.WriteLine("\n\n//클래스 형변환  ");

            Employee emp_class = new Permanent(); //업캐스팅

            Permanent per_class = emp_class as Permanent; // 다운캐스팅

            if (per_class != null)
            {
                per_class.Job(money + 100); //Permanent 기능
            }
        }
    }
}
