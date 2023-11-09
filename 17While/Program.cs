using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tip. while입력 후 tap키 두번을 누르면 기본형이 자동으로 완성 된다.
            //어떤 함수 내에서 bool값이 들어가묜 된다.
            //while (참/거짓)
            bool Check = true;
            while (Check/*조건문*/) {
                Console.WriteLine("무한 출력1"); //실행코드
                Check = false;
            }
            //while문의 작동...
            //조건문 -> 실행코드 -> 조건문 -> 실행코드 -> 조건문 -> 실행코드 -> 조건문 -> 실행코드 -> 조건문 -> 실행코드 -> 조건문 -> 실행코드 ...

            Check = false;
            do {
                Console.WriteLine("무한 출력2");
            } while (Check);
            //do while문의 작동...
            //실행코드 -> 조건문의 순서. (즉 조건이 false여도 한번은 실행이 된다는 점.)

            //while문은 쓸 때 신중해야 하는데 빠져나올 수 있는 조건을 넣어놓고 실행해줘야한다.

            //상수를 넣어주면
            int Count = 0;
            do {
                Count++;
                Console.WriteLine(Count);
            } while (Count < 100);

            Count = 0;
            while (Count < 100) {
                Console.WriteLine(Count);
                Count++;
            }
        }
    }
}
