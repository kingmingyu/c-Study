using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int SwitchTest = 100;
            int Test = 50;

            //1. switch는 == 연산 밖에 못한다.
            switch (SwitchTest) {
                //case Test: -> 오류 //2. 변수는 조건 자리에 오지 못한다. (오직 상수와만 비교할 수 있다.)
                //    break;
                case 0:
                    Console.WriteLine("SwitchTest는 0입니다.");
                    break;
                case 1:
                    Console.WriteLine("SwitchTest는 1입니다.");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("SwitchTest는 2또는 3입니다."); //조건을 겹쳐서 사용 가능.
                    break;
                case 100:
                    Console.WriteLine("SwitchTest는 100입니다.");
                    break;
                default: // default는 else의 역할.
                    Console.WriteLine("모든 조건이 맞지 않습니다.");
                    break;
            }
        }
    }
}
//여기까지가 응용하기 위한 기본적인 내용...