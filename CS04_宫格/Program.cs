using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS06_宫格
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nCount = 3;
            int nRow = 0;
            int nCol = nCount/2;

            int[,] Array = new int[nCount, nCount];
            for(int t = 1 ; t< nCount * nCount ; t++)
            {
                Array[nRow, nCol] = t;
                if (nRow == 0)//是否是第一行
                {
                    nRow = nCount - 1;
                    if (nCol == nCount - 1)//是否是最后一列
                    {
                        nCol = 0;
                    }
                    //Array[nRow, nCol] = t;
                }
            }

        }
    }
}
