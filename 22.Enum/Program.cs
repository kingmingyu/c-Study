using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//기본 자료형 -> 이미 있다.

//사용자 정의자료형중 하나
//class 참조형 사용자 정의
//struct 값형 사용자 정의
//enum 값형 사용자 정의


//enum
//보통 어떤 상태를 표현하는 것 중 나만의 것을 가지고 싶을 때 사용한다.
//다른 언어에서는 정수형 상수라고 하는데 C#에서는 아니다.
//열거형이라고 불리며 사용법.
//명찰의 가까운 값
//값형이다.
enum ItemType
{
    //내가 값의 범위를 지정한 새로운 자료형을 만들어 낼 수 있다는 장점이 있다.
    //switch문과 궁합이 매우 좋다.
    Equip,
    Potion,
    Quest,
    NonSelect
}
//일일이 class EquipItem, class Potion, class Quest와 같이 일일이 많이 만들지는 않음
//class는 class Item1개만 생성.
class Item
{
    //int ItemType = 0; 이렇게 하면 가독성이 떨어지므로
    public ItemType type = ItemType.Equip;

    public void PotionTypeSetting()
    {
        type = ItemType.Potion;
    }
}
namespace _22.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            //값형이고 int라고 생각해도 된다.
            //사용방법 제외하고 거의 int이다.
            NewItem.type = ItemType.Potion;
            NewItem.PotionTypeSetting();

            Console.WriteLine(ItemType.Potion);

            //enum의 좋은점(switch문)
            //switch( __ )에서 __부분에 enum의 객체를 넣어주면 case구문들이 자동완성.
            //switch문이랑 가장 어울린다고 할 수 있다.

            ItemType type = new ItemType();
            switch (type) {
                case ItemType.Equip:
                    break;
                case ItemType.Potion:
                    break;
                case ItemType.Quest:
                    break;
                case ItemType.NonSelect:
                    break;
                default:
                    break;
            }
        }
    }
}