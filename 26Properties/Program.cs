using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//컨트롤 + 스페이스 = 자동완성
class Player{
    int At = 10;

    
    public int GetAt()
    {
        return At;
    }

    public void SetAt(int value)
    {
        if (value > 999) {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true) { Console.ReadKey(); }
        }
        At = value;
    }
    //Get, Set함수는 보통 어떤 맴버변수가 타겟이다.
    //자료형을 선언했다면 이는 int와 관련된 함수라고 명시하는 것.
    public int ProAt
    {
        //프로퍼티의 get함수는 무조건 int를 리턴한다고 보고
        get 
        {
            return At;
        }
        //set함수는 무조건 int하나가 들어온다고 생각한다.
        //그런 외부 값들을 프로퍼티에서는 value라고 기호로 정의해놨다.
        set 
        {
            if (value > 999) 
            {
                Console.WriteLine("최대 수정치를 넘겼습니다.");
                while (true) { Console.ReadKey(); }
            }

            int At = value;
        }
    }
        //정적 프로퍼티
        static int m_StaticValue = 100;
        public static int StaticValue {
        get {
            return m_StaticValue;
        }
        set {
            m_StaticValue = value;
        }
    }
    }
}
namespace _26Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            //NewPlayer.At = 1000000; 와 같은 오류를 Get, Set 함수를 이용하여 막을 수 있음 
            NewPlayer.SetAt(1000000);

            NewPlayer.ProAt = 100; // set
            int PlayerAt = NewPlayer.ProAt; // get
            //프로퍼티의 set, get 활용법. (거의 public 사용되는 모습.)
            //get이나 set 둘 중에 한개만 만들어도 됨.

            Player.StaticValue = 200;
            //static 프로퍼티의 사용
        }
    }
}
//값을 수정하거나 받을때는 거의 대부분 프로퍼티를 이용...