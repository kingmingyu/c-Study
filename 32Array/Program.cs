using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Array
{
    class Program
    {
        class Item
        {
            public string Name;
            public int At;
            public int DF;
        }
        static void Main(string[] args)
        {
            //배열은 기본저긍로 자료형이라고 할 수 있으며 기본자료형에 속한다.
            //선언 방식: 어떤 자료형[]  (ex: int[] Array)

            //c#에서 모든 자료형은 구조체 아니면 클래스에 가까운데
            //기본 자료형도 마찬가지라고 했다. -> 맴버변수와 맴버함수를 갖고 있다.

            
            int[] ArrInt = new int[10]; //[0][0][0][0][0][0][0][0][0][0][0][0] (int가 10개 생겼다.)
            //ArrInt는 int의 배열형(즉 int의 집합)
            //그렇다면 ArrInt[0]은 무슨 자료형인가? -> int의 자료형이다.

            //배열의 특성
            //여러개가 모여있다.
            //연속되어 있다.
            //접근방법 그 모여있는 자료들을 접근하는 방법

            int value = ArrInt[0];

            Console.WriteLine(ArrInt[1]);

            for (int i = 0; i < ArrInt.Length; i++) { //이처럼 for문과 같이 많이 쓴다.
                Console.WriteLine(ArrInt[i]);
            }

            //배열은 언제 사용하느냐??
            //아이템이 100개

            //
            Item[] ArrItem = new Item[10]; 
            //아이템이라는 참조형을 담을 수 있는 공간이 10개 생겼다.
            //아이템이라는 메모리를 가리킬 수 있는 참조형이 10개 생겼다.
            //new Item(); <-> new Item[100];

            for (int i = 0; i < ArrItem.Length; i++) {
                ArrItem[i] = new Item();
            }

            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "전설의검";
            ArrItem[2].Name = "갑옷";
            ArrItem[3].Name = "멋진갑옷";
            ArrItem[4].Name = "포션";

            for (int i = 0; i < ArrItem.Length; i++) {
                Console.WriteLine(ArrItem[i].Name);
            }
        }
    }
}
