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
            int nCount;
            int nRow, nCol;
            Console.WriteLine("行数：");
            nRow = nCol =  nCount =Convert.ToInt32(Console.ReadLine());
            int[,] Array = new int[nRow,nCol];
            for(int Count = 0 ; Count < nRow ; Count++)     //第一列元素赋1
            {
                Array[Count,0] = 1;
            }
            for(int Count = 0; Count < nRow; Count++)
            {
                Array[Count, Count] = 1;
            }

            for (nRow = 2; nRow < nCount; nRow++)
            {
                for (nCol = 1; nCol < nCount-1 ; nCol++)
                {
                    Array[nRow, nCol] = Array[nRow - 1, nCol] + Array[nRow - 1, nCol - 1];
                }
            }
            for (nRow = 0; nRow < nCount; nRow++)
            {
                for (nCol = 0; nCol <= nRow; nCol++)
                {
                    Console.Write(Array[nRow, nCol] + " ");
                    //Console.Write("\t");
                }
                Console.WriteLine();
            }




            //const int nCount = 10;
            //int[][] a = new int[nCount][];
            //for (int nRow = 0; nRow < nCount; nRow++)
            //{
            //    a[nRow] = new int[nRow + 1];
            //    a[nRow][0] = 1;
            //    a[nRow][nRow] = 1;
            //    for (int nCol = 1; nCol < nRow; nCol++)
            //    {
            //        a[nRow][nCol] = a[nRow - 1][nCol] + a[nRow - 1][nCol - 1];
            //    }
            //}
            //for (int nRow = 0; nRow < nCount; nRow++)
            //{
            //    for (int nCol = 0; nCol <= nRow; nCol++)
            //    {
            //        Console.Write("{0}\t", a[nRow][nCol]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //交错数组
        }
    }
}