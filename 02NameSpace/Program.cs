using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//문법을 공부할 때
// 응용법까지 욕심을 내는 경우가 있다.
//게임 프로그래밍에서는 실제코드를 짜면서 보기 전까지는
//응용에 대해서 느낄 수가 없다.
//프로그래밍에서는 경우가 무한대이다.
//배열이라는 것을 배웠다. -> 인벤토리를 만들 때, 오브젝트를 관리할 때 쓸 수 있다.
//이런식으로 항목식으로 공부하면 안됨.


// 네임스페이스의 내용.
//프로그래머가 2명이다.
//RPG를 만들기로 했다.
//몬스터, 무기, 아이템

//A프로그래머
//HP포션
class Potion
{
    //플레이어가 마시면 HP가 참
}

//B프로그래머
//MP포션
class Potion
{
    //플레이어가 마시면 MP가 참
}
//클래스의 이름이 같아서 빨간줄(오류) 발생

//클래스는 식별자.
//식별자가 겹칠 때 문제는 사용할 때.
//클래스 이름이 같을 때 사용할 수 있는 namespace
//표현이라기보다는 분류
namespace APro
{
    class Potion
    {
        //플레이어가 마시면 HP가 참
    }
}

namespace BPro
{
    class Potion
    {
        //플레이어가 마시면 HP가 참
    }
}

