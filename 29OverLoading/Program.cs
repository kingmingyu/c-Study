using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}

class Player
{
    int Hp = 100;
    
    int attDef = 5;
    int fireDef = 5;
    int iceDef = 5;

    //함수의 오버로딩: 함수의 이름은 같지만 인자값이 다름.(이를 컴퓨터는 다르다고 인식하여 사용가능.)
    //아래 함수를 컴퓨터가 인식하는법(Damage int)
    public void Damage(int dmg)
    {
        Hp -= dmg;
    }

    //아래 함수를 컴퓨터가 인식하는 법(Damage float)
    public void Damge(float dmg)
    {
        
    }

    //아래 함수를 컴퓨터가 인식하는법(Damage int int)
    public void Damage(int dmg, DMGTYPE _Type)
    {
        switch (_Type) {
            case DMGTYPE.PYDMG:
                dmg -= attDef;
                break;
            case DMGTYPE.FIREDMG:
                dmg -= fireDef;
                break;
            case DMGTYPE.ICEDMG:
                dmg -= iceDef;
                break;
            default:
                break;
        }

        Damage(dmg);
    }

    //정적함수도 가능
    static void Func(int value)
    {

    }
    static void Func(int value1, int value2)
    {

    }

    //생성자에서도 가능
    public Player(int hp)
    {
        Hp = hp;
    }
    public Player()
    {

    }
}
namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.Damage(100);

            NewPlayer.Damage(40, DMGTYPE.FIREDMG);
        }
    }
}
