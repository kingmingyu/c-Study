using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    //static은 객체화를 하지 않아도 플레이어의 내부는 내부이므로
    //private와 같은 접근제한지정자의 영향을 받지 않는다.
    public static void PVP(Player _Left, Player _Right)
    {
        _Left.Hp -= _Right.Att;
        _Right.Hp -= _Left.Att;
    }
    //public static void PVE(Player _Left, Monster _Right)
    //{
    //    _Left.Hp -= _Right.Att;
    //    _Right.Hp -= _Left.Att;
    //} 문제 발생(접근제한자)

    private int Hp = 100;
    private int Att = 10;
    public void Damage(int _Dmg)
    {
        Hp -= _Dmg;
    }

    public void Damage(Player other)
    {
        //자기자신의 레퍼런스는 자신의 내부에서 모두 public인 상태이다.
        Hp -= other.Att;
    } // 자기 자신의 클래스 내부에서는 private이어도 마음대로 사용가능

    //public void Damage(Monster other)
    //{
    //    Hp -= other.Att;
    //} 는 불가능하다. 접근 제한자 때문.
}

public class Monster
{
    private int Hp = 100;
    private int Att = 10;
    //public static void pvp(player _left, player _right)
    //{
    //    _left.hp -= _right.att;
    //    _right.hp -= _left.att;
    //}
}

namespace _14StaticFunc
{
    class Program
    {
        //아래있는 함수도 클래스에 속한 정적 함수이다.
        //어떤 클래스에 존재하는 Main의 이름을 가진
        //정적멤버함수에서부터 c#프로그램은 시작된다.
        static void Main(string[] args)
        {
            //f12를 누르면 그 클래스로 타고 들어갈 수 있다.
            //타고 들어간다는 것은 그 클래스의 세부내용이 기록되어 있는 곳으로 간다.
            //Console은 정적멤버함수.
            Console.WriteLine("static함수 배우고 있어요.");

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            //클래스에 속하지만 객체를 굳이 만들지 않고도 사용할 수 있는 함수를 정적멤버함수라고 한다.
            Player.PVP(NewPlayer1, NewPlayer2);

            NewPlayer1.Damage(10);
        }
    }
}
