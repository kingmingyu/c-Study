using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //맴버변수(객체가 생기면 만들어지게 되는)
    private int Hp 100;
    private static int StTest = 100;
    public static void PVP(Player Right, Player Left)
    {
        //정적 맴버 변수만이 정적 맴버 함수에서 사용 가능하다.
        StTest = 100;

        //Hp = 100; -> 사용 불가능
        //객체의 영향을 받지 않는 것이 정적 맴버 변수, 정적 맴버 함수이다.(이 말은 객체를 만들지 않고도 사용할 수 있다.)
        //왜?? Player NewPlayer1 = new Player(); 이런식으로 NewPlayer는 무한대로 찍어낼 수 있지만
        //누구의 Hp를 사용할건지는 정적맴버함수에서는 알지 못함.
        //즉 this가 없음.
    }

    public void Damage(int Dmg)
    {
        //c#은 어떻게 이 hp가 플레이어 2의 hp라는 것을 알 수 있었을까?
        //Hp -= Dmg;
        this.Hp -= Dmg;
    }

    public static void TestDamage(Player _this, int Dmg)
    {
        _this.Hp -= Dmg;
    }

    //맴버함수의 호출이란 우리에게 보이지 않지만 어처피 넣을거 대신 넣어준다.
    public void Heal(/*Player this,*/int _Heal) //이런식으로 자기 자신이 함수의 인자값으로 들어가있다고 생각하면 편하다.
    {
        //맴버함수에서 맴버변수를 쓴다면 눈에 보이지 않지만 앞에 this.이 생략된 것이다.
        //this.Hp += _Heal; 처럼.
        Hp += _Heal;
    }

}
namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer2.Damage(100); //사실 모든 맴버함수는 NewPlayer.Damage(NewPlayer2, 100); 이런 꼴 이었던 것이었다.
            Player.TestDamage(NewPlayer2, 100);
            //위 두문장의 행동의 차이는 하나도 없다.
        }
    }
}
