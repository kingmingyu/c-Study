using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//클래스는 왠만하면 자기의 일은 스스로 하자.
//캡슐화하기! (public사용 자제.)

//그 객체의 맴버변수와 관련된 코드를 2번 이상 치게 된다면 함수로 만들어라.

//초반 프로그래밍의 전부
//1. 객체(클래스)를 선언해야 할 때
//2. 함수의 분기
//3. 함수의 통합

//함수는 비대하지 않을 수록 좋다.
//예를 들어 10줄 5줄 짜리 함수를 10개 5개 만들어서
//또 그 함수들을 갖고 10줄 5줄짜리 함수를 만드는 것이 좋다.

class Player
{
    int Att = 10;
    int Hp = 53;
    int MaxHp = 100;

    public void StatusRender()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("공격력: " + Att + " || 체력: " + Hp + "/" + MaxHp);
        Console.WriteLine("------------------------------------------");
    }

    public void HealHp(int potion)
    {
        if (Hp <= MaxHp - potion) {
            Hp += potion;
            Console.WriteLine("");
            Console.WriteLine("체력이 " + potion + "만큼 회복되었습니다.");
            Console.ReadKey();
        }
        else if (MaxHp - potion <= Hp && Hp < MaxHp) {
            int heal = MaxHp - Hp;
            Hp = MaxHp;
            Console.WriteLine("");
            Console.WriteLine("체력이 " + heal + "만큼 회복되었습니다.");
            Console.ReadKey();
        }
        else {
            Console.WriteLine("");
            Console.WriteLine("체력이 풀피라서 회복할 수 없습니다.");
            Console.ReadKey();
        }
    }
}

class Monster
{

}

//에러나 잘못된 선택에 관한 것도 만든다.
enum STARTSELECT
{
    SELECTTOWN,
    SELECBATTLE,
    NONESELECT
}

namespace TextRPG001
{
    class Program
    {
        static void Main(string[] args)
        {
            //객체지향 프로그래밍이란 결국 클래스로 설계하고 객체로 만들어나가는 것.

            //저는 마을과 싸움터로 나누어서(마을로 가시겠습니까 싸움터로 가시겠습니까?) 싸우고 싶다.
            //반복문과 조건문중 어떤 것?? -> 조건문

            //객체화하지않고 쓸 수 있는 함수 -> static함수 or 정적맴버함수.
            //while (true) {
            //    ConsoleKeyInfo KeyInfo = Console.ReadKey(); //키보드로 무엇을 누를때까지 기다려주는 함수.
            //                                                그리고 무엇을 눌렀다면 무엇을 눌렀다고 다시 되돌려줌.
            //                                                자료형이 "ConsoleKeyInfo" int와 같은 자료형이다. "값형"이다.
            //    Console.WriteLine(KeyInfo.Key);
            //}

            static STARTSELECT StartSelect() 
            {
                Console.Clear();
                Console.WriteLine("1. 마을");
                Console.WriteLine("2. 배틀");
                Console.WriteLine("어디로 가시겠습니까?");

                ConsoleKeyInfo CKI = Console.ReadKey();
                Console.WriteLine("");

                switch (CKI.Key) 
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("마을로 이동합니다.");
                        Console.ReadKey();
                        return STARTSELECT.SELECTTOWN; //이처럼 switch문에서는 break대신에 return을 사용해도 된다.
                    case ConsoleKey.D2:
                        Console.WriteLine("배틀로 이동합니다.");
                        Console.ReadKey();
                        return STARTSELECT.SELECBATTLE;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        Console.ReadKey();
                        return STARTSELECT.NONESELECT;
                }



            }//시작한다를 담당하는 함수(마을로 갈 것인지, 싸움터로 갈 것인지.)

            static void Town(Player player)
            {
                int potion = 10;
                while (true) {
                    Console.Clear();
                    player.StatusRender();
                    Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                    Console.WriteLine("1. 체력을 회복한다.");
                    Console.WriteLine("2. 무기를 강화한다.");
                    Console.WriteLine("3. 마을을 나간다.");

                    //switch 인자값에대한 여러가지 경우의 수.
                    //1.                                           --> switch (Console.ReadKey().Key)
                    //2. ConsoleKeyInfo CKI = Console.ReadKey()    --> switch (CKI.Key)
                    //3. ConsoleKey CK = Console.ReadKey().Key     --> switch (CK)

                    switch (Console.ReadKey().Key) {
                        case ConsoleKey.D1:
                            player.HealHp(potion);
                            break;
                        case ConsoleKey.D2:
                            break;
                        case ConsoleKey.D3:
                            return; //return을 하면 함수가 끝나버림
                        default:
                            break;
                    }
                }
            } //마을

            static void Battle()
            {
                Console.WriteLine("아직 개장하지 않았습니다.");
                Console.ReadKey();
            } //배틀

            //메인함수의 시작.

            //첫번째 static
            //
            Player NewPlayer = new Player();

            while (true) {
                //함수 자체의 용도를 생각해라. -> 정말 한가지의 용도로만 사용할 수 있나??
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck) {
                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECBATTLE:
                        Battle();
                        break;
                    default:
                        break;
                }
            } //게임 메인함수 구현.

        }
    }
}

//초기선택
//1. 마을로 간다.
//2. 싸움터로 간다.

//1-1. 마을의 내용
// - 마을의 도착했습니다.
//1. 여관에 들른다.
//2. 공격력을 강화한다.
//3. 나간다.

//2-2. 싸움터의 내용
// - 싸움터의 도착했습니다.
//1. 몬스터가 등장했다.
//2. 데미지를 입혔다. xx의 체력이 남았다.