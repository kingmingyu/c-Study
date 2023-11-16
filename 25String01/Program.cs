using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//언어는 숨쉬는 것.
//붉은 줄이 갔다 -> 왜 갔지? 왜 안되지?
//c#은 자료형이 다르면 대입할 수 없다. ex)int a = "AAA"

//프로그래밍에 있어서 기본기라고 생각하는 것. 3가지.
//1. 디버깅 (중단점[95%정도 된다], 메모리덤프...)
//2. 문자열 (3%)
//3. 파일 입출력 (2%) 정도 ...

namespace _25String01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a 크기 4바이트이다.
            //문자열은 동적 기본자료형이다.
            //문자
            char charactor = 'a';
            //문자열
            //string은 char의 집함.
            string Test = "aaaa";
            //자료형은 c#에서 만들어놓은 기본 구조체이다.

            int AAA = 1000; // <-얘도 구조체이다.(수정할 수 없는)
            //AAA.ToString()은 문자열을 반환하는 int의 맴버함수이다. -> 구조체의 특징.
            //AAA.ToString()은 객체이다.

            Test = AAA.ToString();
            

            Console.WriteLine(Test);

            string Left = "안녕하세요";
            string Right = "날씨가 좋네요.";

            Console.WriteLine(Left + Right);

            string Result = Left + Right;

            Console.WriteLine(Result);

            string Result2 = Left + Right + AAA;

            Console.WriteLine(Result2);

            //정리
            //int는 구조체이고 내부의 맴버변수나 함수가 존재하고
            //그것을 통해서 문자열로 반환해줄 수 있다.
            //즉 기본 자료형들도 구조체이고 그 안의 맴버변수나 맴버함수를 갖을 수 있다.
        }
    }
}
