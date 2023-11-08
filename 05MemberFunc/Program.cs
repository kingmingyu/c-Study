using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    //명사만으로는 부족함.
    int HP;
    int ATT;

    //지형에서 움직인다. 몬스터를 공격한다. NPC와 대화한다.
    //이런 것을 표현하는 것이 맴버함수라고 한다.
    //굉장히 다양한 방법으로 함수를 선언할 수 있다.
    /*리턴값*/void Move/*인자값*/()
    {// <-함수의 시작

    }// <-함수의 끝

    void Talk()
    {

    }

    void Fight()
    {

    }

    void SkillUse()
    {

    }
}

//RPG를 만든다. -> 프로젝트를 만든다.
//주인공이 있다. -> 클래스르 만든다.
//주인공이 공격력이 있다. -> 멤버 변수
//주인공이 공격력으로 때린다. ->멤버 함수
