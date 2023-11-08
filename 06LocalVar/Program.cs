using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Att;
    int Hp;

    void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.")
    }
}
//게임에서 사용하기 위해서 여기까지 설계하였다.
namespace _06LocalVar
{
    //c#은 고지식한 객체지향 언어.
    //클래스밖에 모르는 바보
    //프로그램의 시작조차도 클래스안에 묶어놔야 한다.

    class Program
    {
        //시작용 함수가 있는 것이고
        static void Main(string[] args)
        {
            //객체화라고 하는 굉장히 중요한 작업.
            //클래서는 뭐라고 ? 설계도이다.
            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            //함수 안에 있는 녀석들을 지역변수라고 한다.
            int Att = 0;
            //즉 클래스안에 있으면 멤버변수, 함수 안에 있으면 지역변수라고 한다.
            //지역변수의 규칙1
            //{
            //내부에서만 사용가능
            //}
            //그리고 선언되는 순간 지역변수는 메모리화되고 끝나는 순간 사라짐.(일회용느낌)

            Console.WriteLine("지역변수를 배워봅시다.")
        }
    }
}
