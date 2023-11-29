using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//나는 아이템을 담아두는 인벤토리를 만들고 싶다.
//나는 인벤토리를 만드는데, 인벤토리가 최대 몇개를 담을 수 있는지부터 정해여 한다.
//숫자가 2개 필요한데 x, y이다.(아이템의 총 개수는 x*y개 이다.)
class Inven
{
    int SelectIndex = 0;
    Item[] ArrItem;
    int ArrItemX;

    //인벤토리를 new 하려면 int x, int y 를 넣어주는 방법밖에 없게 만들었다. -> 잘못쓰기도 힘들게 만들어라.
    public Inven(int x, int y)
    {
        //초보프로그래머가 가장 주의해야 할 것.
        //방어코드는 선택이 아니라 필수이다.
        //방어코드란 무엇이냐?? -> switch문의 Defalt와 같은 것
        //혹은 프로그램이 터지거나 오작도아지 않게 들어오는 값들을 체크해서 문제가 없게 만드는 코드
        //함수나 이런곳에서 인자값을 받을 때
        //1. 이걸 검사하고 사용한다.(무조건 검사하고 사용해야 한다.)
        //2. 그냥 사용한다.(비추천)
        if (x < 1) {
            x = 1;
        }
        if (y < 1) {
            y = 1;
        }

        ArrItemX = x;
        ArrItem = new Item[x * y];
    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++) {
            if (i != 0 && i % ArrItemX == 0) {
                Console.WriteLine("");
            }

            if (i == SelectIndex) {
                Console.Write("▣");
            }
            else if (ArrItem[i] == null) {
                Console.Write("□");
            }
            else {
                Console.Write("■");
            }
        }
        
    }

    public void ItemIn(Item item)
    {
        for (int i = 0; i < ArrItem.Length; i++) {
            if (ArrItem[i] == null) {
                ArrItem[i] = item;
                break;
            }
        }
    }

    public void ItemIn(Item item, int order)
    {
        if (order >= ArrItem.Length) {
            for (int i = ArrItem.Length - 1; i > 0 ; i--) {
                if (ArrItem[i] == null) {
                    ArrItem[i] = item;
                    break;
                }
            }
        }
        else {
            if (ArrItem[order] == null) {
                ArrItem[order] = item;
            }
            else {
                for (int i = 0; i < ArrItem.Length; i++) {
                    if (ArrItem[i] == null) {
                        ArrItem[i] = item;
                        break;
                    }
                }
            }
        }
        
    }

    public void SelecItem()
    {
        if (ArrItem[SelectIndex] == null) {
            Console.WriteLine("");
            Console.WriteLine("현재 선택한 아이템창은 비어있습니다.");
        }
        else {
            Console.WriteLine("");
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름: " + ArrItem[SelectIndex].Name);
            Console.WriteLine("가격: " + ArrItem[SelectIndex].Gold);
        }

        switch (Console.ReadKey().Key) {
            case ConsoleKey.UpArrow:
                if (SelectIndex < ArrItemX) {
                    SelectIndex = ArrItem.Length - ArrItemX + SelectIndex;
                }
                else {
                    SelectIndex -= ArrItemX;
                }
                break;
            case ConsoleKey.DownArrow:
                if (ArrItem.Length - ArrItemX <= SelectIndex && SelectIndex <= ArrItem.Length) {
                    SelectIndex = SelectIndex - (ArrItem.Length / ArrItemX - 1) * ArrItemX;
                }
                else {
                    SelectIndex += ArrItemX;
                }
                break;
            case ConsoleKey.LeftArrow:
                if (SelectIndex == 0) {
                    SelectIndex = ArrItem.Length - 1;
                }
                else {
                    SelectIndex -= 1;
                }
                break;
            case ConsoleKey.RightArrow:
                if (SelectIndex == ArrItem.Length - 1) {
                    SelectIndex = 0;
                }
                else {
                    SelectIndex += 1;
                }
                break;
            default:
                Console.WriteLine("방향키를 눌러주십시오.");
                break;
        }
    }
}

