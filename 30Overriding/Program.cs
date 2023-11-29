using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    //디폴트 접근제한지정자는 private.
    protected string Name = "None";
    protected int At = 10;
    protected int Hp = 100;

    //상속의 개념을 지키기 위해서(코드 재활용성)
    //코드를 적제치고 최대한의 효과를 누리고 싶다. -> 함수가 늘어나는 것은 별로이다.
    public void Damage(FightUnit otherUnit/* <- 다형성 player가 될 수도 Monster가 될 수도 있음을 뜻함.*/)
    {
        //각자 플레이어의 것(몬스터, 플레이어)
        int At = otherUnit.DmgAt;
        //int At = otherUnit.DmgAt;

        Console.WriteLine(otherUnit.Name + "에게 " + At + "만큼의 데미지를 입었습니다.");
        Hp -= At;
    }
    //ㅁ생성자는 오버라이딩 할 수 없다.
    //public FightUnit(){
    //
    //}

    //ㅁ정적맴버함수도 오버라이딩 할 수 없다.
    //public static virtual void Test(){
    //this가 없기 때문에 virtual이 안된다.
    //}

    //이 문법의 핵심은 자식에서 만약 나의 *같은 이름의 함수나 프로퍼티*를 재구현했다면
    //자식의 형태의 *같은 이름의 함수나 프로퍼티*를 호출해 주세요. -> 오버라이딩(다형성의 핵심 문법중에 하나이다.): virtual
    //객체지향의 가장 큰 특성중에 하나인 다형성(동적바인딩)
    //부모의 접근제한지정자와 인자의 개수나 내용등은 같아야 한다.(내용만 다르게 구현가능하다.)
    virtual public int GetAt()
    {
        Console.WriteLine("FightUnit의 GetAt");
        return At;
    }
    //프로퍼티는 오버라이딩 가능
    public virtual int DmgAt {
        get {
            Console.WriteLine("FightUnit의 GetAt");
            return At;
        }
    }
}

class Player : FightUnit
{
    int ItemAt = 5;
    public Player(string name)
    {
        Name = name;
    }
    //나는 부모의 GetAt를 재구현했다. 라는 의미(override)
    override public int GetAt()
    {
        Console.WriteLine("Player의 GetAt");
        return At + ItemAt;
    }
    public override int DmgAt {
        get {
            Console.WriteLine("Player의 DmgAt");
            return At + ItemAt;
        }
    }

}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public Monster(string name, int monsterLv)
    {
        Name = name;
        monsterLv = MonsterLv;
    }
    public Monster(string name)
    {
        Name = name;
    }

    public override int GetAt()
    {
        Console.WriteLine("Monster의 GetAt");
        return At + MonsterLv;
    }
    public override int DmgAt {
        get {
            Console.WriteLine("Monster의 DmgAt");
            return At + MonsterLv;
        }
    }
}
namespace _30Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");

            NewPlayer.Damage(NewMonster/*업케스팅*/);
            NewMonster.Damage(NewPlayer/*업케스팅*/);
        }
    }
}
