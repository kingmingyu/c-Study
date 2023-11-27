class GTest<T>
{
    T Data;
}

namespace _44DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //GTest < GTest < GTest<float> > New; <- 이런식으로 제네릭 안에 제네릭을 넣어줄 수 있다.
            Dictionary<string, List<int>> NewDic;

            List<Dictionary<string, LinkedList<Dictionary<string, string>>>> NewTest;

            //이런경우에는 Dictionary쓰지 마라
            //0, 1, 2, 3, 4, 5 -> Key
            //Dictionary<int, int> --> 이럴거면 그냥 List를 써라.

            //왠만하면 그냥 순회방식을 사용하라.
            Dictionary<string, int> DicTest = new Dictionary<string, int>();
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);

            //var은 그 시점에서 가장 알맞은 자료형이 되어 준다.(무엇이든지 될 수 있다.)
            int Number = 100;
            var AA = Number;


            //foreach는 자동적으로 반복하는 문장으로서
            //in을 통해서 각 배열이든 딕셔너리든 리스트든
            //내부의 자료를 그대로 순회할 수 있게 처리해 준다.
            //var은 그때의 가장 적합자료형으로 처리된다.
            //in은 자료구조에서 빼온다라고만 이해해도 된다.
            //그 대신 루프에 대한 제한을 하기가 어렵다.

            //Tip) List와 LinkedList는 for문을, Dictionary는 foreach문을 이용하는 것이 좋다.(Dictionary는 for문 사용을 자제하는 것이 좋다.)
            foreach (var item in ListTest) {
                Console.WriteLine(item);
            }

            foreach (var item in LinkedListTest) {
                Console.WriteLine(item);
            }

            foreach (var item in DicTest) {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<string, int> item in DicTest) {
                Console.WriteLine(item.Value);
            }

            foreach (KeyValuePair<string, int> item in DicTest) {
                Console.WriteLine(item.Key);
            }

        }
    }
}