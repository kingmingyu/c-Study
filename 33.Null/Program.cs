using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int mAt;

    public int At {
        get { return mAt; }
        set { mAt = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer1 = new Player();
        //가리키는게 없비 비워놓겠다.
        //참조형의 데이터 구조를 가지는 자료형들은(클래스) new를 하게 되면
        Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer1.At);
        Console.WriteLine(NewPlayer2.At);
    }
}

