using System;

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
        static void ArrayRemoval(int[] Array,ref int TotalDigits)
        {
            int[] Array_b = new int[Array.Length];
            int bIndex = 0;//数组b的下标
            //int nArray;
            for(int aIndex = 0; aIndex < Array.Length; aIndex++)
            {
                int temp = 0;
                for(temp = 0; temp < bIndex; temp++)
                {
                    if(Array[aIndex] == Array_b[temp])
                    {
                        break;
                    }
                }
                if(temp == bIndex)
                {
                    Array_b[bIndex] = Array[aIndex];
                    bIndex++;

                }
                //输出B数组
                
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Array_b[i];
            }
            TotalDigits = bIndex ;
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
            int TotalDigits = 0;
            ArrayInit(Array_a);
            ArrayOutPut(Array_a);
            Console.WriteLine("-----------------------");
            ArrayRemoval(Array_a,ref TotalDigits);
            Console.WriteLine(TotalDigits);
            ArrayOutPut(Array_a);

            
        }
    }
}
