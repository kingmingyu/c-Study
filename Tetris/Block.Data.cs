using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Block
{

    List<List<string[][]>> AllBlock = new List<List<string[][]>>();
    void DataInit()
    {
        for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; BT++) { 
            AllBlock.Add(new List<string[][]>());
            for (int BD = 0; BD < (int)BLOCKDIR.BD_MAX; BD++) {
                AllBlock[BT].Add(null);
            }
        }


        #region S
        //짝대기의 T
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "■", "□", "□", "□"},
            new string[] { "■", "□", "□", "□"},
            new string[] { "■", "□", "□", "□"},
            new string[] { "■", "□", "□", "□"},
        };
        //짝대기의 R
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "■", "■", "■"},
            new string[] { "□", "□", "□", "□"},
            new string[] { "□", "□", "□", "□"},
            new string[] { "□", "□", "□", "□"},
        };
        //짝대기의 B
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "□", "□", "□"},
            new string[] { "■", "□", "□", "□"},
            new string[] { "■", "□", "□", "□"},
            new string[] { "■", "□", "□", "□"},
        };
    //짝대기의 L
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "■", "■", "■" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region T
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "□", "□", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
    }
}

