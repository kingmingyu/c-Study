using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자정의 자료형
interface QuestUnit
{
    //int A = 0; -> 맴버변수 X

    //함수의 형태만 물려줄 수 있는 문법이다. (디폴트가 public)
    void Talk(QuestUnit otherQuestUnit);

    void Event(QuestUnit otherQuestUnit);
}

//상속은 여러개 받을 수 없다. -> 인터패이스를 쓰는 근본적인 이유.
class FightUnit
{
    int At;
    int Hp;
    int Dmg;

    public void Damage()
    {

    }
}

//인터페이스는 함수구현을 강제할 수 있다.
//인터페이스는 상속이라고 안하는사람도 있다. 포함의 개념이다라고 말하는 사람도 있다.
//인터페이스를 상속받았다고 치면 인터페이스에 정의한 함수는 무조건 구현해야 한다.
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit otherQuestUnit)
    {

    }

    public void Event(QuestUnit otherQuestUnit)
    {

    }
}

class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit otherQuestUnit)
    {

    }
    public void Event(QuestUnit otherQuestUnit)
    {

    }
}
namespace _31Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NPC newNPC = new NPC();


            NewPlayer.Talk(newNPC/*업캐스팅이 된다*/);
            newNPC.Talk(NewPlayer/*업캐스팅이 된다*/);
        }
    }
}
