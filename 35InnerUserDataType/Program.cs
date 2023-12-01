using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Inven
{
    private int SelectIndex = 0;
    //자기 클래스 내부에 들고있다.
    //public 남들이 알면 짜증나는 일이 있다면 private쓰기.
    //Tip. 일단 private를 써라.
    public class InvenIcon//Inven이라는 클래스 내부에 있지만 Inven의 private는 사용 불가능.
    {
        //SelectIndex = 1; -> 불가능
    }

    public class InvenSlot
    {
        int Index;
        public void Select(Inven inven)
        {
            //자신을 갖고 클래스의 맴버변수를
            //마치 public처럼 사용할 수 있다.
            inven.SelectIndex = 100;
        }
    }
    public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();

        NewInvenSlot.Select(this/*나자신 --> Inven*/);
    }
    //어느 방향으로 움직이겠느냐?
    //이럴거면 밖에 있건 안에 있건 무슨 상관인가?
    //1. 이름 겹침에서 자유롭다.
    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN,
    }
    void SelectMove(INVENDIR invendir/*방향을 의미할만한 인자값*/)
    {

    }
}

class Player
{
    //그 클래스가 자기만 사용할 때 가장 많이 사용된다.
    //플레이어의 내부에 넣어줄 수도 있다.
    //다른 곳에 정의될 수 있다.
    public enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE,
    }

    PLAYERJOB Job = PLAYERJOB.NOVICE;

    //직업과 관련된 맴버변수도 있어야 할 것.
    void ClassChange()
    {

    }
} 
namespace _35InnerUserDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            Inven NewInven = new Inven();

            Inven.INVENDIR IDIR = Inven.INVENDIR.ID_LEFT;
        }
    }
}

//단일책임의 원칙.
//온전히 하나의 클래스가 자신의 내부에서 모든 걸 처리할 수 있게 하려면 자신과 밀접히 관련된
//자료형들도 자신 내부에 들고 있는 것이 좋다.