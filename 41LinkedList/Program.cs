using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Node<T>
{
    //몇개가 되건 상관없다.
    //보통 게임 맵을 연결할 때 많이 사용된다.
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkedList<T>
{
    public Node<T> First;
    public Node<T> Last;
}

namespace _41LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //시퀀스 노드형
            LinkedList<int> LList = new LinkedList<int>(); //40에서 만든 노드를 클래스의 형태로 자동으로 관리(연결)해준다.
                                                           //(Next와 Prev를 자동으로 연결해줌.)

            LList.AddFirst(10);//최초에는 AddFirst를 하나 AddLast를 하나 상관이 없다.(맨앞과 맨뒤가 없기 때문)
            //LList.AddLast(10);와 완전히 같은 문장이라고 볼 수 있다.
            LList.AddFirst(20); //가장 앞에 붙인다.
            LList.AddFirst(33); //여기서 가장 앞은 33이 된다.
            LList.AddLast(90); //가장 뒤에 붙인다.
            //결과: 33 20 10 90

            //LList.Remove(10); //10의 값을 가졌으면 지운다.
            //LList.RemoveFirst();
            //LList.RemoveLast();

            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next; //Cur은 현재 20을 가르킨다.

            LList.AddAfter(Cur, 999); //Cur이 20을 가르키므로 그 다음에 999를 넣는다.

            LList.Clear(); //다 지워라~
                           //(List, LList, Dictionary에서도 모두 Clear()이다.)

            //순서대로 출력
            for (LinkedListNode<int> StartNode = LList.First; StartNode != null; StartNode = StartNode.Next) {
                Console.WriteLine(StartNode.Value);
            }

            Console.WriteLine("");
            //뒤에서부터 출력
            for (LinkedListNode<int> EndNode = LList.Last; EndNode != null; EndNode = EndNode.Previous) {
                Console.WriteLine(EndNode.Value);
            }

            
        }
    }
}//배열과의 차이점.
//배열은 중간에 쏙 빼는 것이 쉽지 않은데        ex) 1, 2, 3, 4, 5 -> 1, 2, 4, 5 (쉽지 않음)
//노드는 중간에만 쏙 빼는 것이 손쉽게 가능하다. ex) 1, 2, 3, 4, 5 -> 1, 2, 4, 5 (쉽게 가능)

//Linked List에서 기억해야 할 것 2가지
//1. LinkedList<int> --> 노드들을 관리해주는 애
//   LinkedList.First();
//   LinkedList.Last(); <-- 를 이용한다는 점
//2. LinkedListNode<int> --> 노드 사이사이를 타고다니는 클래스.
//   LinkedListNode<int> StartNode = LList.First; <-- 이런식으로 응용한다는 점.
