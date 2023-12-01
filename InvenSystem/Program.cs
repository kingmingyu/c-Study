using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//내가 만들었건 만들지 않았건 인터페이스란 내가 가용할 수 있는 코드를 쓸 때
//내가 쓸 때 인터페이스(C#의 인터페이스를 의미하는게 아니다.)라고 한다.
//어떻게 설계해야하는지는 각자의 선택에 따른다.
class Program
{
    static void Main(string[] args)
    {
        // * * * * *
        // * * * * *
        // * * * * *
        Inven NewInven = new Inven(5, 3);

        NewInven.ItemIn(new Item("철검", 100));
        NewInven.ItemIn(new Item("갑옷", 100));
        NewInven.ItemIn(new Item("포션", 10), 6);
        NewInven.ItemIn(new Item("마나 포션", 10), 100);
        NewInven.ItemIn(new Item("체력 포션", 10), 6);


        while (true) {
            //이런 객체간의 구조를 만들 때 약간 도움이 될만한 규칙들
            //SOLID
            //1. 단일 책임의 원칙
            //2. 개방 폐쇄의 원칙
            //3. 리스코브 치환의 원칙
            //4. 인터페이스 분리의 원칙 -> 이것을 말하려는 것
            //ex) 함수를 잘개쪼개서 만든다음
            //    그 잘개쪼갠 함수들을 조합해서 새 기능을 만들어 내라.
            //5. 의존성역전의 원칙
            Console.Clear();
            NewInven.Render();
            switch (Console.ReadKey().Key) {
                case ConsoleKey.UpArrow:
                    NewInven.SelectMove(Inven.DIRECTION.UP);
                    break;
                case ConsoleKey.DownArrow:
                    NewInven.SelectMove(Inven.DIRECTION.DOWN);
                    break;
                case ConsoleKey.LeftArrow:
                    NewInven.SelectMove(Inven.DIRECTION.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    NewInven.SelectMove(Inven.DIRECTION.RIGHT);
                    break;
                default:
                    Console.WriteLine("방향키를 눌러주십시오.");
                    break;
                }

            }
    }
}



