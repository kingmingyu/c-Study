using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zone
{
    public string Name = "None";

    public List<Zone> LinkZone = new List<Zone>();

    public Zone(string name)
    {
        Name = name;
    }

    public Zone Update()
    {
        while (true) {
            Console.Clear();

            Console.WriteLine("이곳은 " + Name + "입니다.");

            Console.WriteLine("이곳에서 이동할수 있는 장소 리스트:");

            for (int i = 0; i < LinkZone.Count; i++) {
                Console.WriteLine((i + 1).ToString() + ". " + LinkZone[i].Name);
            }

            //ConsoleKey.D1(int로는 49)
            //형변환 가능한 녀석이 있고 가능하지 않은 녀석이 있다.
            //enum은 int로 변환이 가능하다.
            int Number = (int)Console.ReadKey().Key;
            Number -= 49;

            //방어코드

            return LinkZone[Number];
        }
    }
}

namespace _42NodeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Zone NewZone0 = new Zone("태초마을");
            Zone NewZone1 = new Zone("초보 사냥터");
            Zone NewZone2 = new Zone("중급 사냥터");
            Zone NewZone3 = new Zone("중급마을");
            Zone NewZone4 = new Zone("고급 사냥터");

            NewZone0.LinkZone.Add(NewZone1);
            NewZone0.LinkZone.Add(NewZone2);

            NewZone1.LinkZone.Add(NewZone3);
            NewZone1.LinkZone.Add(NewZone0);

            NewZone2.LinkZone.Add(NewZone3);

            NewZone3.LinkZone.Add(NewZone4);

            Zone StartZone = NewZone0;

            while (true) {
                StartZone = StartZone.Update();
            }
        }
    }
}
