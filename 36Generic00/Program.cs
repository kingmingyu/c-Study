using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정적 클래스는 정적 변수와 정적 함수만을 내부에 갖는다. -> 생성자를 만들 수 없다.
public static class GTest
{
    //제네릭 함수
    //맴버함수에도 통용된다.
    //자료형을 변수처럼 사용하고 싶을 때.
    //함수의 식별자에 <다양한 자료형을 대표할 이름>
    //이것을 ""__제네릭__""
    public static void ConsolePrint<T>(T value)
    {
        Console.WriteLine(value);
    }
    public static T ReturnConsolePrint<T>(T value)
    {
        Console.WriteLine(value);
        return value;
    }

    //제네릭 여러개도 가능.
    public static T ReturnConsolePrint<T, U>(T value1, U value2)
    {
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        return value1;
    }
}

class CashItem
{

}

class GameItem
{

}

//재네릭 클래스
class Inven<T>
{
    //GameItem[] ArrInvenItem;
    //CashItem[] ArrInvenItem; 와 같이 내용은 같지만 이름만 달라야 할 때 사용하는 것이 제네릭

    T[] ArrItemInven;

    public void ItemIn(T item)
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint(1.12342343f); //실수
        GTest.ConsolePrint(1000); //정수
        GTest.ConsolePrint("Hello World"); //문자열

        GTest.ReturnConsolePrint("Hello", "World");

        Inven<GameItem> NewGameItemInven = new Inven<GameItem>(); //재네릭 무조건 명시적으로 만들어줘야 한다.
        GameItem GameItem = new GameItem();
        NewGameItemInven.ItemIn(GameItem);

        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        CashItem CashItem = new CashItem();
        NewCashItemInven.ItemIn(CashItem);
    }
}

