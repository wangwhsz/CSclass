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
            //Array[nRow, nCol] = 1;
            //for(int t = 1 ; t< nCount * nCount ; t++)
            //{
            //    Array[nRow, nCol] = t;
            //    if (nRow == 0)//是否是第一行
            //    {
            //        //nRow = 0;
            //        //nRow = nCount - 1; 
            //        //????
            //        if (nCol == nCount - 1)//是否是最后一列
            //        {
            //            nRow++;
            //            //nCol = 0;

            //        }
            //        else
            //        {
            //            nRow = nCount - 1;
            //            nCol++;
            //        }
            //        //Array[nRow, nCol] = t;

            //    }




            //    else            //不是第一行的话
            //    {
            //        if(nCol == nCount - 1)//是最后一列的话
            //        {
            //            nRow--;
            //            nCol = 0;
            //        }
            //        else
            //        {

            //            if(Array[nRow-1,nCol-1] != 0)
            //            {
            //                nRow++;
            //            }
            //            else
            //            {
            //                nRow--;
            //                nCol++;
            //            }
            //        }
            //    }
            //    Array[nRow, nCol] = t;
            //}
            for (int t = 1; t <= nCount * nCount; t++)
            {
                Array[nRow, nCol] = t;
                if (nRow == 0) //如果是第一行
                {
                    if (nCol == nCount - 1) //如果是最后一列
                    {
                        nRow++;
                    }
                    else
                    {
                        nRow = nCount - 1;
                        nCol++;
                    }
                }
                else
                {//如果不是第一行
                    if (nCol == nCount - 1)//如果是最后一列
                    {
                        nRow--;
                        nCol = 0;
                    }
                    else if (Array[nRow - 1, nCol + 1] != 0)
                    {
                        nRow++;
                    }
                    else
                    {
                        nRow--;
                        nCol++;
                    }
                }
            }
            for (nRow = 0; nRow < nCount; nRow++)
            {
                for (nCol = 0; nCol < nCount; nCol++)
                {
                    Console.Write(Array[nRow, nCol]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
