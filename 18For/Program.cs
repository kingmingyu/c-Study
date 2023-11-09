using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18For
{
    class Program
    {
        static void Main(string[] args)
        {
            //while문과 for문은 함수의 중괄호 안에서만 사용할 수 있다.
            //함수 밖에서는 사용할 수 없다.

            //for(초기화문; 조건문; 증감문)
            //{
            //  실행코드
            //}
            //사실 for문은 필요없다. while문이 있기 때문..
            //하지만 for문의 장점은 접근성.
            //초기화와 조건, 증감을 for라는 키워드로 간편화함.
            //한방에 변수를 선언 후 초기화하고 그걸로 조건을 비교하고 그 변수를 변화시키는 코드를 한줄에 다 담았다.
            for (int i = 0; i < 100; i++) {
                Console.WriteLine(i);
            }
            //초기화문 -> 조건문 -> 실행코드 -> 증감문
            // -> 조건문 -> 실행코드 -> 증감문 -> 조건문 -> 실행코드 -> 증감문 -> 조건문 -> 실행코드 -> 증감문 -> 조건문 -> 실행코드 -> 증감문

            //단항 연산자(변수 하나와 연산자만 있으면 실행되는 연산자.)
            //정수형일때 ++하면 1증가, --하면 1감소.

            int y = 0; //이런식으로 초기화문을 for밖으로 뺄 수도 있다.
            for (; y < 100; y++) {

            }

            //for문에 아무것도 없으면 while이다.
            for (; /*true*/; ) {
                Console.WriteLine(100);
            } 
        }
    }
}

//대표적인 반복문 3가지.
//while, do while, for