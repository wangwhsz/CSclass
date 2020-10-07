using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS08_阶乘
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPos = 1;
            int[] Array = new int[200];
            int nCarry = 0;
            int nSum = 0;
            Array[0] = 1;
            int nNum = 20;
            for(int index = 2;index <= nNum; index++)
            {
                Fact(Array, index, ref nPos);
            }
        }
        static void Fact(int[] a,int nNum,ref int nPos)
        {
            int nCarry = 0;
            int nSum = 0;
            for (int index = 0 ; index < nPos; index++)
            {
                
                nSum = a[index] * nNum;
                a[index] = nSum % 10;
                nCarry = nSum / 10;

            }
        }
    }
}
