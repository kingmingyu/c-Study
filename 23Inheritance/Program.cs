using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//상속이란 코드 재활용성을 향상시키기 위해서 -> 똑같은 코드 2번 치기 싫다.
//함수도 마찬가지.
//어떤 계열이 있느냐를 파악하는 감.(플레이어와 몬스터는 싸우기 위해 있는 계열이 아닌가 ?)

//C#에서 상속이란 오직 하나만 가능하다.(클래스 상속을 여러개 받는 언어들도 존재하지만 c#은 아니다.)

//방법은 공통되는 기능을 하는 맴버변수와 맴버함수를 걷어내는 것부터 시작.
class FightUnit
{
    protected int Att = 10;
    protected int Hp = 100;

    public void Damamge(FightUnit otherUnit)
    {
        //나는 FightUnit이지만 이 안에서 Player의 기능을 쓰고 싶은 것.
        //다운캐스팅
        //Player OtherPlayer = otherUnit;
        //다운 캐스팅은 최대한 지양해라.(피해라.) -> 안쓰고 해결할 수 있는 방법이 많다.
        //플레이어를 실수로 몬스터를 변경할 수도 있게 된다.
    }
}
//       public  protected   private(디폴트)
//범위:  외부    자식        나 
class Player : FightUnit //내려준다 or 상속시킨다라고 한다.
{
    int Lv = 1;

    public void Heal()
    {
        Hp = 100;
    }
}
class Monster : FightUnit
{
    int Exp = 10;
}
namespace _23Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

            //FightUnit FU = NewPlayer; -> 플레이어의 부분을 모두 포기하겠다.(Lv, Heel 못씀)
            //업캐스팅
            //자식이 부모형이 되는 것. 그러므로 자식의 능력은 버린다.
            //다운캐스팅
            //부모가 
            NewPlayer.Damamge(NewMonster);
            NewMonster.Damamge(NewPlayer);
        }
    }
}
//형변환이 되느냐 마느냐는 메모리 구조에 달려있다.
