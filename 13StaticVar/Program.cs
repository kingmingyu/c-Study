using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//static

//몬스터가 100마리가 죽으면 뭔가를 하기로 했다 -> static(정적맴버변수)사용
class Monster
{
    static int MonsterDeathCount = 1;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}

class Player
{
    //일반적인 멤버변수와 다른점.
    //static을 붙이게 되면 정적멤버변수라고 한다.
    //정적 멤버변수는 일반적인 멤버변수와는 다르게 객체화를 하지 않고도 사용할 수 있다.
    //+그 사용법이 클래스의 이름만으로도 사용할 수 있다.
    //객체에 귀속된 것이 아니라, 클래스 그 자체에 귀속되고 데이터 영역에 메모리가 할당된다.
    public static int PlayerCount = 0;

    public int att = 10;
    public int hp = 100;

    //클래스 내부에서는 사용할 수 있다.
    public void Setting(int _at, int _hp)
    {
        att = _at;
        hp = _hp;
    }
}

namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;
            //이런식으로 객체화를 전혀 하지 않고 사용할 수 있다.
            //이런 정적 멤버변수는 데이터 영역에 메모리가 할당 된다.
            //객체들은 정적맴버변수를 사용할 수 없다(NewPlayer.PlayerCount -> X)

            //즉 정적멤버는 어떤 클래스가 공유하고 싶은 값
            //예를 들어 몬스터 클래스라면 현재 존재하는 모든 몬스터의 수.
            //객체를 아무리 만들어도 정적 멤버는 그 객체와의 관련성은 객체 내부에서 사용할 수 있다 뿐이지
            //객체의 개수만큼 만들어지는 것은 아니다.
            //즉 모든 객체가 공유하는 하나의 변수이다.

            //이 멤버변수라고 하는 녀석들은 각각 존재한다.(NewPlayer1의 att,hp는 10, 100 2는 20, 50 3은 100, 500)
            //즉 플레이어를 3번 new하게 되면 플레이어가 3개 생긴 것이고 그 플레이어는 각각의 hp를 갖고 있다.
            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);


            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            //모든 객체가 값을 공유할 필요가 있는 데이터를 정의하는데 사용한다.
            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();
        }
    }
}

//코드: 상수, 클래스 선언 그 자체 함수의 내용 그 자체 수정이 불가능한 녀석들이 들어감
//데이터: 정적 멤버 변수
//힙: new 클래스명() 만들어진 클래스 객체들의 본체가 여기있다.
//스택: 함수의 실행 메모리 영역(그 박스안에 들어있는 지역변수) 스택에 있는 지역변수 레퍼런스들은 힙영역에 있는 것들을 가르킬 뿐이다.
//따라서 메모리도 주소값의 크기만큼 갖게 된다.