using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Att;
    int Hp;
    public void Test(int _Dmg)
    {
        _Dmg = 1000;
    }
}
namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            //함수의 인자값
            int Value = 0;
            Player NewPlayer = new Player();
            NewPlayer.Test(Value);

            Console.WriteLine(Value);
            //실행하면??
            //2가지의 경우의수
            //1. Value의 값은 1000이다.
            //2. Value의 값은 0이다.
            //1번이라고 말을 하면 메모리를 이해하지 못했다. 데이터의 흐름을 이해하지 못하고 있다.
            //이것을 이해하기 위해 값과 위치를 이해 해야한다.
            //기본적으로 Value와 _Dmg는 위치가 다르고, 인자의 역할이 Value의 값만을 가져와서 _Dmg에 넣어주는 역할이다.
            //따라서 값만을 받은 _Dmg의 변화는 Value에 어떤 영향도 주지 못한다.(기본적으로 위치가 다르기 때문!)

            //그럼 Player함수를 통해 Value의 값을 변화시키려면??
            //return을 이용하면 된다.
            //Value = NewPlayer.Test(Value); <- 이런식으로
            //이것을 값형의 처리라고 한다.
        }
    }
}
