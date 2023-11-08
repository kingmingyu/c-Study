using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int Att = 10;
    public int Hp = 100;

    public void Attack(Monster monster)
    {
        monster.Hp -= Att;
    }
}

class Monster
{
    public int Att = 10;
    public int Hp = 100;

    //함수의 추가설명
    public void Attack(Player player)
    {
        //플레이어의 HP는 얼마일까요??
        // 100 - 10 = 90이다.
        player.Hp -= Att;
    }

    public void Test(int value)
    {
        value = 1000;
    }
}
namespace _12Memory02_Reference_
{
    class Program
    {
        static void Main(string[] args)
        {
            //클래스가 객체화된 녀석은 레퍼런스라고 하고,
            //지금까지 봐왔던 int, bool같은 것들은 값형 이라고 한다.

            //이 값형과 레퍼런스형은 메모리의 위치와 사용법이 다르기 떄문에 다르게 동작한다.

            //레퍼런스라고 하는 것은 힙에 생성된 어떠한 메모리의 위치를 가리키는 값이다.

            //NewPlayer.할때 이 '.'은 그냥 쓰면 된다라고 생각 -> 얕은 이해 (안에 값을 끌어내고 싶으면 .을 사용한다.)
            //내가 가르키고 있는 위치에 있는 HP를 사용하겠다. -> 정확한 이해
            //따라서 메인함수에서의 클래스의 사용은 클래스 안의 public 자료형의 값을 변환시킬 수 있다.
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

            //우리가 배웠던대로라면 몬스터가 자신의 공격력으로 플레이어를 때린 것이다.
            //전 솔루션의 Memory(Value)에서는 아래처럼 실행해도 값이 변하지 않았지만
            //이번에는 둘의 Hp가 90으로 깎인다.
            //레퍼런스 값은 어느 위치를 가르키는 것, 값형은 그냥 자기 값이 그대로 쓰이는 것을 의미!!
            //new를 하게 되면 힙 영역에 메모리가 생긴다.
            NewMonster.Attack(NewPlayer);
            NewPlayer.Attack(NewMonster);

            int value = 100;
            NewMonster.Test(value);
        }
    }
}

//Player NewPlayer <- 이 부분은 스택에 메모리값이 할당되고(이때 Player class의 크기는 주소값의 크기)
//그 뒤에 부분인 new Monster()은 힙에 메모리 값이 할당됨. (크기는 int자료형이 2개 있으니까 8바이트)
//NewMonster.Attack(NewPlayer)라는 부분이 실행되면 스택에 NewPlayer.Attack부분이 할당
//이때 스택에 할당된 NewPlayer.Attack의 주소값은 힙 부분에 할당된 new Monster()을 가르키게 되고
//NewMonster.Attack(NewPlayer)라는 구문이 실행되면 힙 부분의 new Monster()의 값을 직접 건드리기 때문에
//실제 new Monster안의 지역변수 값이 바뀌게 되는 것이다.
//그 후 NewMonster.Attack(NewPlayer)이 끝나면 스택에서 종료된다.



//값형과 레퍼런스 형을 구분할 줄 알아야 한다.
//기본 자료형을 선언만 하면 그 녀석들은 값형이다.

//자기가 만든 클래스를 new 클래스명();
//해서 만든 것을 그 클래스명에 받으면 그것은 레퍼런스 형이다.
//즉 클래스가 객체화된 것은 레퍼런스 형이다.

//코드: 상수, 클래스 선언 그 자체 함수의 내용 그 자체 수정이 불가능한 녀석들이 들어감
//데이터: 정적 멤버 변수
//힙: new 클래스명() 만들어진 클래스 객체들의 본체가 여기있다.
//스택: 함수의 실행 메모리 영역(그 박스안에 들어있는 지역변수)