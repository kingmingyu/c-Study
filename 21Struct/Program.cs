using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//컨트롤 시프트 u -> 대문자로 변경하는 단축키.

struct StructData
{
    //클래스와 비슷한데 안되는 것이 있다.
    //리터럴 초기화가 안된다.
    public int a; // = 100; 이게 안된다.
    public int b; // = 0; 이 기본이다.

    public void Func()
    {
        a = 100;
        b = 100;
    }

    static public void Test(StructData Data)
    {
        Data.a = 1000;
    }
}

namespace _21Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            StructData NewData = new StructData();

            NewData.a = 10;
            NewData.b = 10;

            //참조형과 값형이 있다.
            //클래스를 객체화하면 그것은 참조형(래퍼런스형).
            //즉 래퍼런스형은 함수가 끝나면 스택영역에서 누군가를 가르치는 값이 날아가는 것이지 
            //힙 영역에 있는 본체는 그대로 살아있다.

            //아래 있는 구조체는 값형이다.
            //클래스와 거의 비슷하게 사용할 수 있지만 참조형과 값형의 큰 차이를 가지고 있다.
            //레퍼런스형(클래스)은 힙영역에 본체를 가르키는 반면 값형(구조체)은 본체를 지니고 있는 것임. 따라서 함수가 끝나서 종료되면 본체도 종료.
            StructData.Test(NewData);
        }
    }
}
