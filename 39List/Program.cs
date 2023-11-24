using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{

}

class MyList<T>
{
    int[] Arr = new int[0];
    int Capa = 0;
    int Count = 0;

    public void Add(T value)
    {
        if (Count + 1 >= Capa) {
            //Capa 확장
        }
    }
}
namespace _39List
{
    class Program
    {
        static void Main(string[] args)
        {
            //내가 만든애가 아닌데 선언 가능
            //내가 관리해달라고 요청하는 것이 매번 바뀌기 때문에 제네릭 클래스이다.
            //(즉 프로그래밍에서 없으면 안되는 존재이기 때문에, 당연하게 쓰이기 때문에 언어차원에서 미리 만들어놨다.)

            //배열형, 시퀸스
            //List<Item> NewList = new List<Item>();
            List<int> NewList = new List<int>();

            //자료: 넣어준 int
            for (int i = 0; i < 10; i++) {
                Console.WriteLine((NewList.Count + 1).ToString() + "Add");
                Console.WriteLine("Capacity: " + NewList.Capacity); //배열의 크기
                Console.WriteLine("Count: " + NewList.Count); // 자료의 크기
                NewList.Add(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Contains");
            //참색에는 유리하지 않은 자료구조라고 본다.
            //인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조이다.
            //내부에 자료가 있는지 없는지 판단한다.
            if (NewList.Contains(8)) {
                Console.WriteLine("내부에 8이 있습니다.");
            }

            if (NewList.Contains(99999)) {
                Console.WriteLine("내부에 99999가 있습니다.");
            }
            else {
                Console.WriteLine("내부에 99999가 없습니다.");
            }

            //인덱서 혹은 연산자 겹지정이라고 부른다.
            Console.WriteLine(NewList[5]);

            //Console.WriteLine(NewList[10]); //OutOfRange 오류발생.
            //자료의 개수로 판단하지 배열의 크기는 중요하지 않다. Capa가 16이어도 자료가 10개면 10부터 OutOfRange이다.
            //                                                    (0, 1, 2, 3, 4, 5, 6, 7, 8, 9)

            int[] Arr = NewList.ToArray();

            NewList.Remove(10);  //10이 있다면 지운다. (없으면 안지움)
            NewList.RemoveAt(1); //첫번째를 지운다.(0번쨰도 있다는 것 명심)
          //NewList.RemoveAll 다른 리스트 혹은 배열을 넣어 비교해서 중복되면 지운다.
            NewList.RemoveRange(0, 2);//0번쨰부터 2개 지워라.

            for (int i = 0; i < NewList.Count; i++) {
                Console.Write(NewList[i]);
            }
            Console.WriteLine("");
        }
    }
}
