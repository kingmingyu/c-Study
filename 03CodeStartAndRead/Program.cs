using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CodeStartAndRead
{
    class Program
    {
        //코드가 실행된다고 함은 어디서부터인가.
        //한줄한줄씩 os가 내 프로그램을 읽어주는 것이다.
        //os: windows, 리눅스, 안드로이드 등의 운영체재..

        //쪼개서 읽지 말아라, 아래 것이 보이면 프로그램은 그 아래서부터 실행 된다.
        //static void Main(string[] args)
        //  {
        //      이 사이의 내용을 읽는다.
        //      이것먼저 읽음.
        //  }
        static void Main(string[] args)
        {
            //한줄한줄 읽는다는 것이 좀 힘든 일이지만
            //그걸 ide가 도와준다.
            //디버깅중 코드 한줄씩 실행: f10을 누르면 된다.

            // 의미가 있는 코드
            Console.WriteLine("하하");
            Console.WriteLine("호호");
            Console.WriteLine("히히");
            Console.WriteLine("흐흐");
            Console.WriteLine("햐햐");
            Console.WriteLine("효효");
        } //여기에 도달 시에 프로그램 끝.
    }
}

//코드는 위에서 아래로, 왼쪽에서 오른쪽으로..