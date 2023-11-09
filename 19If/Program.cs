using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19If
{
    class Program
    {
        static void Main(string[] args)
        {
            int Test = 100;

            //if는 조건문이다.
            if (Test == 100) {
                Console.WriteLine("Test == 100입니다.");
            }

            //Tip. Ctrl RR을 누르면 자신이 지정한 같은 모든 변수명을 한번에 변경가능.
            int ElseIfTest = 10;
            if (ElseIfTest == 100) {
                Console.WriteLine("ElseIfTest는 100입니다.");
            }
            else if (ElseIfTest == 10) {
                //위의 조건과 연계되어 위 조건이 false일 때 아래
                Console.WriteLine("ElseIfTest는 10입니다.");
            }


            int ElseTest = 5;
            if (ElseTest == 10) {
                Console.WriteLine("ElseTest는 10입니다.");
            }
            else if (ElseTest == 100) {
                Console.WriteLine("ElseTest는 100입니다.");
            }
            else {
                Console.WriteLine("연계된 모든 조건이 거짓이었다.");
            } //모든 것이 거짓이었다면 else가 실행 -> true가 한개라도 있으면 else는 실행X.
        }
    }
}
