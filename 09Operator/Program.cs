using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Hp = 100;
    void Damage()
    {
        Hp = Hp - 10;
    }

    public int Plus(int _Left, int _Right)
    {
        int Result = _Left + _Right;
        return Result; // return _Left + _Right; 와 같은 말
    }
}

namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // '=' 대입연산자.
            //함수의 리턴된 값이나 연산이된 값, 리터럴 값을 받을 수 있는 변수에 넣어라.
            int Result = 0;
            int Left = 7;
            int Right = 3;

            //산술연산자
            //리턴값이라는 것은 외부에 연산값이나 객체 상태 값 등을 끝나고 나면 외부에 반환하는 것을 말하고
            //이런식으로 = 연산자가 있다면 오른쪽부터 실행된다.
            //연산자의 우선순위라고 하는데,
            //대입연산자와 산술연사자가 있으면 산술연산자가 먼저 실행되고 대입연산자가 실행됨.
            //산술연산자에서는 *. %가 먼저 되고
            //그 다음에 +, -가 됨.
            //'()'연산자는 연산자의 실행순서를 내가 지정할 수 있게 해준다.
            Result = Left + Right; //더하기
            Result = NewPlayer.Plus(Left, Right);
            Result = Left - Right; //빼기
            Result = Left * Right; //곱하기
            Result = Left / Right; //나누기
            Result = Left % Right; //나머지
            //이런식으로 산술 연산을 할 수 있고
            //한가지 주의할 점은 나누기와 나머지에 0을 넣으면 안됨.
            //10 / 0 은? 수학에서 불가능하다.
            //컴퓨터에서는 제로디비전이라고 해서 아예 오류가 남
            //프로그램이 실행 도중에 터질 정도의 오류이므로 반드시 주의해야함.

            //비교연산자
            //비교연산자는 논리형으로 리턴이 됨.
            //논리형은 bool 이라는 것이 있다.
            //bool은 'true' or 'false'만을 리턴할 수 있다.(참과 거짓, 1과 0) -> 참과 거짓이 상수화 된 것이 'true'와 'false'이다.
            //100, 200 이런 것을 상수라고 하는데 정수형상수이다.(정수로 표현되는 상수)
            bool BResult;
            BResult = Left > Right; //Letf가 Right보다 큰가? -> 참이라면 true 거짓이라면 false.
            BResult = Left < Right; //Letf가 Right보다 작은가?
            BResult = Left >= Right; //Letf가 Right보다 크거나 같은가?
            BResult = Left <= Right; //Letf가 Right보다 작거나 같은가?
            BResult = Left == Right; //Letf가 Right와 같은가?
            BResult = Left != Right; //Letf가 Right와 다른가?
            //이런식으로 참과 거짓을 이용하여 나중에 조건문에서 유용하게 사용된다.

            // bool 논리 연산자
            BResult = true && false; //AND -> 모두 true일때만 true 즉 연속되어 있을 때 그중 단 1개라도 false이면 false이다.
            BResult = true || false; //OR -> 하나라도 true가 있다면 true
            BResult = true ^ false; //XOR -> 양쪽이 다르다면 true, 같다면 false
            BResult = true ^ true;
            BResult = false ^ false;
            BResult = true ^ true ^ true;
            BResult = !true; //NOT ->true이면 false, false이면 true

            //축약 연산자
            Result = 0;
            Result += 20;
            Result -= 10;
            Result *= 10;
            Result /= 10;
            Result %= 19;
        }
    }
}
