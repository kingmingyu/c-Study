using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//왜 메모리를 알아야 하느냐?
//메모리란 사실 c#을 배워야 하기 때문에 알아야 하는것이 아님.
//c#이 아니라 모든 프로그램의 근간이 되는 개념이기 때문이다.
//무슨 말이냐? -> 공짜는 없다. 메모리를 지불한다.
//메모리의 구조를 안다는 것은 코드의 동작원리를 아는 것과 같다.

class Player
{
    int Hp = 100;
    int Att = 10;

    //함수의 인자값은 지역변수이다.
    //지역변수의 특징: 함수가 끝나면 사라진다.
    public void Damage(int _Dmg)
    {

    }
}

namespace _10Memory00_Func_
{
    class Program
    {
        //아래 것을 메인 함수라고 함.
        //static을 빼면 함수의 모양을 가지고 있고 사실상 함수이다.
        //이곳을 시작이라고 잡은 함수(c#의 규칙이다.)
        //Main이라는 이름의 함수에서부터 시작한다.
        //함수의 실행조차도 공짜는 없다.
        static void Main(string[] args)
        {
            //함수는 메모리화 되지 않음
            Console.WriteLine("메모리 1차함수");

            //즉 메인함수의 크기는 지역변수 + a로 계산되는데
            //최소한 지역변수를 다 포함할 수 있는 크기만큼은 main함수의 크기가 되야함.
            int Value = 0;
            //객체를 만들었다. -> 메모리를 지불했다.
            //좀 더 근본적으로 이야기를 하면 단 하나도 공짜가 없다.
            Player NewPlayer = new Player();
        }
    }
}

//정리 프로그램이 실행되면 가장 우선적으로 main함수가 실행된다.
//이때 main함수의 크기는 지역변수(int Vlaue, 4바이트) + 함수(Player) + a의 크기이다.
//그 후 메인함수 내에서 Console.WriteLine("메모리 1차함수");라는 함수가 실행되면 잠시 함수를 main함수 내에서 실행하고 실행이 완료되면 바로 사라짐.
//다음 Player라는 함수가 실행되면 main함수 메모리공간 앞에 Player라는 함수의 메모리 공간이 할당된다.
//이때 크기는 Player함수의 지역변수 크기 + a가 되겠다.
//Player함수의 실행이 끝나면 할당되었던 메모리 공간은 사라진다.
//main함수 또한 실행을 마치면 스택에서 사라지고 main함수의 종료는 프로그램의 종료이므로 스택, 힙 데이터 코드가 사라지고 우리프로그램 또한 종료된다.
