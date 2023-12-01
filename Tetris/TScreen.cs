using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BK
{
    W,
    V,
    B
}

class TScreen
{
    List<List<string>> BlockList = new List<List<string>>();

    public void SetBlock(int y, int x, string BlockType)
    {
        BlockList[y][x] = BlockType;
    }
    public void Render()
    {
        for (int y = 0; y < BlockList.Count; y++) {
            for (int x = 0; x < BlockList[y].Count; x++) {
                Console.Write(BlockList[y][x]);
            }
            Console.WriteLine("");
        }
    }

    public void Clear()
    {
        for (int y = 0; y < BlockList.Count; y++) {
            for (int x = 0; x < BlockList[y].Count; x++) {
                if (y == 0 || y == BlockList.Count - 1) {
                    BlockList[y][x] = "▣";
                    continue;
                }
                BlockList[y][x] = "□";
            }
        }
    }

    public TScreen(int X, int Y)
    {
        for (int y = 0; y < Y; y++) {
            BlockList.Add(new List<string>());
            for (int x = 0; x < X; x++) {
                BlockList[y].Add("□");
            }
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++) {
            BlockList[0][i] = "▣";
            BlockList[BlockList.Count - 1][i] = "▣";
        }
    }
}
