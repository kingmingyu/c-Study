class DicTest
{
    Dictionary<string, int> NewDicTest = new Dictionary<string, int>();

    public void Print(string Name)
    {
        if (false == NewDicTest.ContainsKey(Name)) { //contains를 많이 이용해야 한다.
            return;
        }
        Console.WriteLine(NewDicTest[Name]);
    }
    public void Add(string name, int value)
    {
        if (NewDicTest.ContainsKey(name)) {
            return;
        }
        NewDicTest.Add(name, value);
    }
}

namespace _43Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //연관 복합(배열형)
            //string 키
            //int 벨류(데이터)
            //즉 키와 벨류를 연결해놓고 탐색에 편리한 자료구조이다.
            Dictionary<string, int> NewDic = new Dictionary<string, int>();

            NewDic.Add("일이에요", 1); //값의쌍이 연결
            NewDic.Add("이에요", 2);
            NewDic.Add("뭘까요 ?", 342347);
            NewDic.Add("와와 재밌다.", 123);
            //NewDic.Add("와와 재밌다.", 456); -> 똑같은 키를 2개 넣어줄 수 없다.(프로그램이 터진다.)
            //딕셔너리는 같은 키를  넣어줄 일이 있다면 사용하지 마라.

            //그에 따른 방어코드
            if (false == NewDic.ContainsKey("일이에요")) {
                NewDic.Add("일이에요", 1);
            }

            //인덱서 or 연산자 겹지정이라고 합니다.
            Console.WriteLine(NewDic["일이에요"]); //딕셔너리는 이렇게 사용할 수 있다.(찾는 작업에 특화된 녀석이다.)
            Console.WriteLine(NewDic["이에요"]);
            //Console.WriteLine(NewDic["ㄴㅇ런ㅁ얄"]); <- 터진다.(key값이 없기 때문에.)

            string Key = "당연히 없는값 테스트용";

            if (NewDic.ContainsKey(Key)) { //Key라는 값이 있으면 NewDic에서 Key에 해당하는 값을 출력해라.(보통 이렇게 쓴다.)
                Console.WriteLine(NewDic[Key]);
            }

            if (NewDic.ContainsKey("와와 재밌다.")) { //Key라는 값이 있으면 NewDic에서 Key에 해당하는 값을 출력해라.(보통 이렇게 쓴다.)
                Console.WriteLine(NewDic["와와 재밌다."]);
            }

            NewDic.Remove("와와 재밌다."); //딕셔너리는 대부분 키를 갖고 조작.

            //딕셔너리의 사용
            //이처럼 딕셔너리는 클래스를 따로 만들어서 감싸는게 편하다.
            DicTest NewTest = new DicTest();

            NewTest.Add("하하하하", 1);
            NewTest.Add("하하하하", 1);
            NewTest.Add("하하하1", 1);
            NewTest.Add("키입니다", 9999);

            NewTest.Print("키입니다");
            NewTest.Print("하하하1");
        }
    }
}