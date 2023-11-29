using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected int Att = 10;

    public FightUnit() //자식과 부모가 2개다 생성자가 있을 때는 반드시 부모 클래스의 생성자부터 실행.
    {
        int a = 0;
    }
}
class Player : FightUnit
{
    //생성자
    //만들어질 때 한 번 실행되어주는 함수
    //특징
    //1. 리턴값이 없다.(void, int, string등 앞에 안써줌)
    //2. class이름과 같다.
    public Player()
    {
        Att = 100;
        int Number = 0;
    }//눈에 보이진 않지만 만들지 않아도 이 함수는 자동으로 만들어진다.
    //무조건 자신의 클래스의 메모리를 리턴해주는 함수이다.
}

namespace _24ClassConstructer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
        }
    }
}
