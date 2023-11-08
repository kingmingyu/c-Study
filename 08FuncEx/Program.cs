using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //접근제한자를 입력하지 않으면
    //디폴트로 private
    //private이 일반적이기 때문에 기본적임
    //속성들은 외부에서 접근하지 못하는게 일반적으로 좋다.
    //공격력은 공격력 그 자체만으로 의미가 있지만
    //그 의미가 명확해지지 않음

    int Hp = 100;
    int Att = 10;
    int Lv = 1;

    //플레이어의 레벨이 얼마인지 알고 싶다.
    //인자 값이 아니고 리턴값을 사용
    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용
    //외부에 알려줘야 하기 때문에 알려주는 순간 함수가 끝나게 된다.
    //return이라는 문장을 사용하면 얼마나 많은 코드가 이 return아래에있든 함수가 종료하게 된다.
    public int GetLv()
    {
        //return을 하는 순간 함수가 끝나고
        //아래에 친 코드들은 모두 의미가 없다.
        return Lv;
        Lv = 10000;
    }

    //상태라는 건 맴버변수
    //어떤 상태가 변화하는 순간
    public void LvUp()
    {
        Att = 100;
        Hp = 1000;
    }

    public void SetHp(int _Hp)
    {
        //내가 hp가 0이 되는 순간만 체크할 수도 있고 내가 hp가 100이 되는 순간만 체크할 수도 있다.
        //가장 큰 핵심은 디버깅이 된다.
        Hp = _Hp;
    }

    //함수는 보통 선언과 내용으로 나뉘게 되는데
    //void[리턴값] Func[이름또는 식별자] ()[인자값]
    public void Func()
    {
        //내용
    }
    //함수란 보통 클래스 외부와의 소통을 위해서 만든다
    //Damage는 맞는다라는 뜻.
    //(int _Dmg)를 넣는다는 것은 외부에서 한개의 int 값을 넣어서 플레이어에게 전달해 주겠다.
    public void Damage1(int _Dmg)
    {
        Hp = Hp - _Dmg;
    }

    //리턴값은 자신이 리턴해주고자 하는 자료형과 동일한 자료형이어야 한다.
    public int DamageToHpReturn(int _Dmg)
    {
        Hp = Hp - _Dmg;
        return Hp;
    }
    //인자값이 두 개가 될 수도 있다.
    //개수는 신경 알써도 될정도로 100개이상은 넣을 수 있다.
    public void Damage2(int _Dmg, int _SubDmg)
    {
        Hp = Hp - _Dmg;
        Hp = Hp - _SubDmg;
    }

}
//여기까지가 플레이어가 어떤 사양과 내용을 가졌다.(설계도)
//아직 만든 것은 아니다.
namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //NewPlayer.Hp = 0; 이런식으로 클래스 내부의 속성을 건드려서 원치 않는 결과를 야기할 수 있음.

            NewPlayer.SetHp(0);
            NewPlayer.LvUp();

            //이런식으로 외부의 값을 받아서 객체(인스턴스)가 내부의 상태를 변화시키기 위해서 함수를 선언하는 경우가 많음.
            NewPlayer.Damage1(10);
            NewPlayer.Damage1(20);
            NewPlayer.Damage2(10, 20);

            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHpReturn(50));
        }
    }
}
