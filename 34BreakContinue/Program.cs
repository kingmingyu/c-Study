using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//continue와 break는 가장 가까운 반목문의 증감문, 조건문으로 이동한다.
namespace _34BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) {
                if (i % 2 == 0) {
                    continue;//이 문장을 만나면 가장 가까운 반복문의 증감문으로 바로 이동한다.
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++) {
                if (i == 50) {
                    break;//이 문장을 만나면 가장 가까이 있는 반복문을 나간다.
                }
                Console.WriteLine(i);
            }
        }
    }
}
