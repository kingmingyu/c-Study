using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using _28Partial;//이러면 namespace생략할 수 있다.


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();

        NewPlayer.Damage();
        NewPlayer.EventStart();

        //이런식으로 partial로 끊어주면 한개의 클래스를 여러개로 나눌 수 있음.
    }
}


