using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TScreen NewSC = new TScreen(10, 15);

            Block NewBlock = new Block(NewSC);

            while (true) {
                for (int i = 0; i < 100000000; i++) {
                    int a = 0;
                }
                NewBlock.Move();
                Console.Clear();
                NewSC.Render();
                NewSC.Clear();
            }
        }
    }
}
//for (int y = 0; y < 15; y++) {
//    for (int x = 0; x < 10; x++) {
//        if (y == 0 || y == 14) {
//            Console.Write("■");
//        }
//        else {
//            Console.Write("□");
//        }

//    }
//    Console.WriteLine("");
//}
//덮어 씌우는 기능이 있나 ??(방법 1)
//Console.CursorLeft = 6;
//Console.CursorTop = 6;
//Console.WriteLine("▣");
//Console.CursorLeft = 6;
//Console.CursorTop = 7;
//Console.WriteLine("▣");
//Console.CursorLeft = 6;
//Console.CursorTop = 8;
//Console.WriteLine("▣");
//Console.CursorLeft = 6;
//Console.CursorTop = 9;
//Console.WriteLine("▣");
//아예 판을 한번에 그린다.(방법 2)