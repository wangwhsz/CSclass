using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_随机数
{
    
         
    
    class Program
    {
        //随机函数初始化数组
        static void ArrayInit(int[] a)
        {
            Random rd = new Random();
            int counter = 0;
            for (counter = 0; counter < a.Length; counter++)
            {
                //a[counter] = rd.Next(200);
                int temp = rd.Next(200);
                int t;
                for( t = 0; t < counter; t++)
                {
                    if (temp == a[t])
                        break;
                    
                }
                if (t == counter)
                {
                    a[counter] = temp;
                }
                else
                {
                    counter--;
                }
            }
        }
        //数组输出
        static void ArrayOutPut(int[] a)
        {
            int counter = 0;
            for(counter = 0 ; counter < a.Length ; counter++)
            {
                Console.Write(a[counter] +"\t");
            }
        }
        static void ArraySort(int[] a)
        {
            //int i =3;
            ////int j;
            //for(i = 0; i < a.Length; i++)
            //{
            //    for (int j = i + 1; j < a.Length; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            int temp;
            //            temp = a[j];
            //            a[j] = a[i];
            //            a[i] = temp;
            //        }
            //    }
            //}
            

            //写个插入排序
            
        }
        static void Main(string[] args)
        {
            int[] nArray = new int[10];
            ArrayInit(nArray);
            ArrayOutPut(nArray);
            Console.WriteLine();
            ArraySort(nArray);
            ArrayOutPut(nArray);

        }
    }
}
//meiju shuzu helloworld chengfabiao 