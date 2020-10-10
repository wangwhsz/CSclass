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
            int nNum = 30;
            for(int index = 2;index <= nNum; index++)
            {
                Fact(Array, index, ref nPos);
                
            }

            //函数求阶乘
            long nSum_1 = 1;
            FactAndOpt(30 , ref  nSum_1);
            Console.WriteLine("20的阶乘是{0}", nSum_1);



            ///
            ArrayOutPut(Array, nPos);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="nNum"></param>
        /// <param name="nPos"></param>
        static void Fact(int[] a,int nNum,ref int nPos)
        {
            int nCarry = 0;//进位
            int nSum = 0;//每一位上的乘积
            for (int index = 0 ; index < nPos; index++)
            {
                nSum = a[index] * nNum + nCarry;
                a[index] = nSum % 10;
                nCarry = nSum / 10;
                //a[index + 1] += nCarry;

            }
            while(nCarry != 0)
            {
                a[nPos] = nCarry % 10;
                nPos++;
                nCarry = nCarry / 10;
            }
        }
        static void ArrayOutPut(int[] Array,int nPos)
        {
            for(; nPos > 0; nPos--)
            {
                Console.Write(Array[nPos-1]);
            }//
        }
        static void FactAndOpt(int nNum,ref long nSum)
        {
            for(int i = 2; i <= nNum; i++)
            {
                nSum *= i;
            }
        }
    }
}
