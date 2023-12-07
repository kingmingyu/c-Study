using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//객체지향 어렵지 않다.
//난 위에서부터 블럭이 떨어지는 것을 만들고 싶다.

enum BLOCKDIR
{
    BD_L,
    BD_T,
    BD_R,
    BD_B,
    BD_MAX,
}
enum BLOCKTYPE
{
    BT_I, //짝대기
    BT_L, //오른쪽 갈고리
    BT_J, //왼쪽 갈고리
    BT_Z, //왼쪽 삐뚫이
    BT_S, //오른쪽 삐뚫이
    BT_T, //법규
    BT_O, //네모
    BT_MAX,
}
partial  class Block
{
    int X = 0;
    int Y = 0;
    string[][] Arr = null;
    //List<List<string>> BlockData = new List<List<string>>();


    TScreen Screen = null;

    public Block(TScreen screen)
    {
        Screen = screen;
        DataInit();

        SettingBlock(BLOCKTYPE.BT_T, BLOCKDIR.BD_L);
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
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
        for (int y = 0; y < 4; y++) 
        {
            for (int x = 0; x < 4; x++) 
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }
                Screen.SetBlock(Y + y, X + x, Arr[y][x]);
            }
            
        }
    }
}
