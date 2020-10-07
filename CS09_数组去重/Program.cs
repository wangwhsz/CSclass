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
                Array[index] = rd.Next(0, 30);
            }
        }
        static void ArrayRemoval(int[] Array,int n)
        {
            int[] Array_b = new int[Array.Length];
            int nCount = 0;
            int nArray;
            for(int aIndex = 0; aIndex < Array.Length; aIndex++)
            {
                int temp = 0;
                for(temp = 0; temp < aIndex; temp++)
                {
                    if(Array[aIndex] == Array_b[nCount])
                    {
                        break;
                    }
                }
                if(nCount == Array_b.Length)
                {

                }
                temp = Array[aIndex];
                
            }
        }
        static void Main(string[] args)
        {
            int[] Array_a = new int[10];
            
            ArrayInit(Array_a);
            
        }
    }
}
