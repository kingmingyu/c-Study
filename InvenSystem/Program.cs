using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Clear();
            NewInven.Render();
            NewInven.SelecItem();
        }
    }
}
