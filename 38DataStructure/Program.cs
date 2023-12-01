﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료구조를 만들어 보는건 게임 프로그래머의 언어와 같은 기초 소양.
//자료구조에 대해서 알아보자.

//자료구조(資料構造, 영어: data structure)는 컴퓨터 과학에서 효율적인 접근 및 수정을 가능케 하는 자료의 조직, 관리, 저장을 의미한다.
//더 정확히 말해, 자료 구조는 데이터 값의 모임, 또 데이터 간의 관계, 그리고 데이터에 적용할 수 있는 함수나 명령을 의미한다.

//총알이 1000발 발싸된다. 어떻게 관리하지?
//NPC가 500명이 있다. 그중에서 '피오나'라는 이름의 NPC가 있는데 어떻게 찾지
//--> 이런것을 알아낼 수 있게 해주고 관리하기 쉽게하는 것이 자료구조이다.

class MyDataStruture<T>
{
    //삽입
    public void Push(T data)
    {
        if (/*data라는 자료가 들어왔을 때 내 사이즈를 오버하면*/) {
            Ex(/*적절한 수*/1000);
        }

        //이외에도 여러가지 예외처리 할 것이 많다.
    }
    //탐색
    public T Find(T data)
    {
        return data;
    }
    //지우기
    public void Remove(T data)
    {

    }
    //확장
    public void Ex(int size)
    {

    }
    //자료구조에서는 이런식으로 만들어줘야 함
}
namespace _38DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //자료구조라는 건
            //int 10개를 관리할 때
            //0 1 2 3 4 5 6 7 8 9

            //자료구조에는 다음의 구조나 인터페이스를 지원한다.
            //함수로 표현한다.
            //1. 삽입(넣는다.)
            //2. 탐색
            //3. 지우기
            //4. 확장

            int[] Arr = new int[10]; // -> 자료구조이다.
            //자료구조에는 보통 컨테이너라는 용어를 사용하는데
            //시퀸스 컨테이너 (넣어주면 넣어주는대로 순서대로 차곡차곡 저장되는 자료구조이다.)
            //연관 컨테이너 (10, 100, 20, 9999를 넣으면 자동으로 10, 20, 100, 9999로 정리된다. 즉 규칙에 의해서 자료의 순서를 바꾼다.
            //              단, 자료의 변형은 허용되지 않는다. ex)Dictionary[c# 해쉬맵], map[c++])
            //어뎁터 컨테이너 (시퀸스 컨테이너나 연관 컨테이너에 속하나 거기에서 한 가지 더 변형이 일어난 형태.
            //                 List[c#], Vector[c#에서는 없고 c나 c++에 있다.]라는 이름이 들어가 있으면 시퀸스이다.(거의 100%)
            //                 ex)stack, queue))
            //라고 분류된다.

            //데이터의 메모리 구조는
            //배열형 (자료가 따닥따닥 붙어있다.)
            //노드형 (어떤 자료가 자기랑 연결된 다음 자료를 알고 있다. 연결하는 방법이 매우 많음.)
            //이 대부분이다.

            //즉 자료구조의 종류에 대하여 말할 때는 시퀸스 + 배열형 or 시퀸스 + 노트형 이런식으로 2가지를 합쳐서 표현한다.

            Arr[0] = 0;//삽입
            Arr[1] = 1;

            int[] Arr2 = Arr;

            Arr = new int[15];//확장하고 싶을 때.

            MyDataStruture<int> MDS = new MyDataStruture<int>();

            //100을 넣어줘
            MDS.Push(100);
            //50을 찾아줘
            MDS.Push(50);
            //넓혀줘(보통은 자동으로 이뤄진다. Push안에 같이 구현하는 경우가 많다.)
            MDS.Ex(5000);
        }
    }
}
