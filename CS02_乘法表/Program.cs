using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS02_乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nCount = 9;
            int nRow = 1;
            int nCol = 1;
            for(;nRow <= nCount; nRow++)
            {
                for(nCol = 1;nCol <= nRow ; nCol++)
                {
                    Console.Write("{0}x{1}={2}\t", nRow, nCol, nRow * nCol);
                }
                Console.WriteLine();
            }
        }
    }
}
