using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//객체지향 어렵지 않다.
//난 위에서부터 블럭이 떨어지는 것을 만들고 싶다.

enum BLOCKTYPE
{
    BT_I, //짝대기
    BT_L, //오른쪽 갈고리
    BT_J, //왼쪽 갈고리
    BT_Z, //왼쪽 삐뚫이
    BT_S, //오른쪽 삐뚫이
    BT_T, //법규
    BT_O, //네모
}
class Block
{
    int X = 0;
    int Y = 0;

    List<List<string>> BlockData = new List<List<string>>();


    TScreen Screen = null;

    public Block(TScreen screen)
    {
        Screen = screen;

        for (int y = 0; y < 4; y++) {
            BlockData.Add(new List<string>());
        }


    }

    private void Input()
    {
        //키를 눌렀다. 그러므로 Console.ReadKey()가 리턴된다.(맞긴 하지만 그전에도 이미 컴퓨터는 키를 체크하고 있다.)
        if (Console.KeyAvailable == false) {
            return;
        }
        switch (Console.ReadKey().Key) {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            default:
                break;
        }
    }
    public void Move()
    {
        //내가 어떤 키든 눌렀을 때만 input을 실행해라
        Input();
        for (int i = 0; i < 4; i++) {
            Screen.SetBlock(Y+i, X, "■");
        }
    }
}

//상속을 내리고 가상함수를 쓴다.
class StickBlock
{

}

//상속을 내린다. (방법 1)
