using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int Hp = 100;
    public int At = 10;

    public bool IsDeath()
    {
        Console.WriteLine("이 함수는 플래이어가 죽었는지 살았는지 테스트 하는 함수입니다");
        Console.WriteLine("Hp가 0이하로 떨어지면 죽습니다.");

        return Hp <= 0;
    }

    public void TestFunc(Player player)
    {
        TestFuncPart1(player);
    }
    public void TestFuncPart1(Player player)
    {
        TestFuncPart2(player);
    }
    public void TestFuncPart2(Player player)
    {
        player.At = 20;//null일때 직접 값을 수정해야 할때 오류가 발생한다. (위에서는 오류 발생X)
    }
}
namespace _37Reference01
{
    class Program
    {
        static void ArrTest(int[] arrTest)
        {
            arrTest[0] = 99999;
        }

        static void ClassTest(Player player)
        {
            Console.WriteLine("공격력을 테스트 해볼까요?");
            Console.WriteLine("그냥 해보는 것입니다.");
            player.At = 10000;
        }
        static void Main(string[] args)
        {
            //Player NewPlayer 이 변수는 할 수 있는 일이 어떤 녀석을 가리키는 일밖에 하지 못한다.
            //즉 다른 녀석을 가르킬 수 있다.
            Player NewPlayer = new Player();
            Player NewPlayer2 = NewPlayer; // 같은 곳을 가르키는 2개(1개를 수정하면 다른 1개도 마찬가지로 고쳐진다.)
                                           // ex) NewPlayer2.At = 99;로 바꾸면 NewPlayer.At또한 99로 바뀐다.
                                           // 이름이 다르다고 다른 것이 아니다.(같은 애를 가르키고 있는지 아닌지가 중요한 부분)
            NewPlayer.At = 50;

            NewPlayer = new Player(); //At는 다시 10이 된다. 이전에 new Player()은 영원히 사라졌다고 볼 수 있다(못찾음 -> C#에서는 자동으로 지워진다.)

            //배열을 만들자마자 초기화하는 방법
            //한번에 모든 값을 다 넣어줘야 한다.
            int[] ArrNumber = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //힙에 있는 녀석이 이 함수에 들어갔다 나왔다라는 개념.
            ClassTest(NewPlayer);

            ArrTest(ArrNumber); //[0]번째가 바뀌었다. --> 배열도 레퍼런스형이다.

            //ClassTest(null); //null을 만나는 순간 프로그램이 터진다.
            
            Player NewPlayer3 = null;

            //NewPlayer3.IsDeath();

            NewPlayer.TestFunc(null); //F10을 이용하여 터진 순간의 오른쪽 아래에 호출스택을 보면 여기로 오게 된다. (오류의 근원을 알려줌.)
        }
    }
}
