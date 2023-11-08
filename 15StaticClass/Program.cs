using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//함수의 위치는 문법적으로는 어디에 있던지 상관없다.
//class Player
//{
//    static void Main(string[] args) <-이것이 있는곳이 프로그램의 시작점이 됨.
//    {
//    }
//}와 같이 전혀 상관이 없다는 점.


static class StClass
{//정적 클래스란 정적 맴버변수와 정적맴버함수만을 가질 수 있는 클래스이다.
    //int test = 100; 처럼 일반 맴버변수는 선언만 해도 오류가 나게 된다.
}
namespace _15StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console.WriteLine은 정적 멤버함수이다.");
        }
    }
}
//정적 클래스
//정적 맴버변수
//정적 맴버함수