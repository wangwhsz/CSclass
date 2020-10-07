using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS09_数组去重
{
    class Program
    {
        static void ArrayInit(int[] Array)
        {
            Random rd = new Random();
            for(int index = 0; index < Array.Length; index++)
            {
                Array[index] = rd.Next(7);
            }
        }
        static void ArrayRemoval(int[] Array)
        {
            int[] Array_b = new int[Array.Length];
            int nCount = 0;//数组b的下标
            //int nArray;
            for(int aIndex = 0; aIndex < Array.Length; aIndex++)
            {
                int temp = 0;
                for(temp = 0; temp < nCount; temp++)
                {
                    if(Array[aIndex] == Array_b[temp])
                    {
                        break;
                    }
                }
                if(temp == nCount)
                {
                    Array_b[nCount] = Array[aIndex];
                    nCount++;

                }
                //输出B数组
                
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Array_b[i];
            }
            //temp = Array[aIndex];
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    Console.Write(Array_b[i] + "\t");
            //}
        }
        static void ArrayOutPut(int[] Array)
        {
            for(int index = 0; index < Array.Length; index++)
            {
                Console.Write(Array[index]+"\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] Array_a = new int[10];
            
            ArrayInit(Array_a);
            ArrayOutPut(Array_a);
            Console.WriteLine("-----------------------");
            ArrayRemoval(Array_a);
            ArrayOutPut(Array_a);

            
        }
    }
}
