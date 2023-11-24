using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//노드는 단순히 자료구조에서만 사용되는 것은 아니다.
//자료구조라고 하면 자료를 보관해야 하므로
//제네릭을 이용한다.
class Node<T>
{
    public T Data;
    //자신안에 자기 자신을 또 가지는 형태로 되어있는 클래스들을 노드라고 할 수 있다.
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T data)
    {
        Data = data;
    }
}

class Room
{

}//방이 다른방과 연결되있고 또 다른 방과 연결되있고 등 실전에서는 이런 곳에 쓰인다.
namespace _40Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> Node1 = new Node<int>(10);
            Node<int> Node2 = new Node<int>(999);
            Node<int> Node3 = new Node<int>(578);

            Node1.Next = Node2;
            Node2.Next = Node3;

            Node3.Prev = Node2;
            Node2.Prev = Node1;

            Node<int> CurNode = Node1;

            while (CurNode != null) {
                Console.WriteLine(CurNode.Data);
                CurNode = CurNode.Next;
            }

            Node<int> RCurNode = Node3;

            while (RCurNode != null) {
                Console.WriteLine(RCurNode.Data);
                RCurNode = RCurNode.Prev;
            }
        }
    }
}
