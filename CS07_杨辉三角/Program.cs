using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS07_杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 
            int nRow = 8, nCol = 8;
            int[][] Array = new int[nRow][];
            for(int Count = 0 ; Count < nRow ; Count++)     //第一列元素赋1
            {
                Array[Count][] = 1;
            }
            for(int Count = 0; Count < nRow; Count++)
            {
                Array[Count, Count] = 1;
            }

            for (nRow = 2; nRow < 8; nRow++)
            {
                for (nCol = 1; nCol < 7 ; nCol++)
                {
                    Array[nRow, nCol] = Array[nRow - 1, nCol] + Array[nRow - 1, nCol - 1];
                }
            }
            for (nRow = 0; nRow < 8; nRow++)
            {
                for (nCol = 0; nCol <= nRow; nCol++)
                {
                    Console.Write(Array[nRow, nCol] + " ");
                    //Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}