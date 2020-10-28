using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS12_参数类型
{
    class Program
    {
        //重载方法和形参的名以及返回值无关
        //static int GetSum(int n)
        //{
        //    if (n == 1)
        //        return 1;   
        //    return n + GetSum(n - 1);
        //}
        //static int GetSum(int m,int n)
        //{
        //    return m + n;
        //}
        //static double GetSum(double m, double n)
        //{
        //    return m + n;
        //}



        /// <summary>
        /// 可变参数
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int GetSum(params int[] a)
        {
            int s = 0;
            foreach(var n in a)
            {
                s += n;
            }
            return s;
        }
        //递归输出逆序数
        static void RevOpt(int n)
        {
            if (n < 10)
                Console.Write(n);
            Console.Write(n % 10);
            RevOpt(n / 10);
        }

        //在调用函数内部可不对out参数赋值，但是在被调函数中必须对out参数赋值
        static void Calc(int n1,int n2,out int sum,out int disc)
        {
            sum = n1 + n2;
            disc = n1 - n2;
        }
        static void Swap(ref int n1,ref int n2)
        {
            //Console.WriteLine("qian");
            //Console.Write(n1);
            //Console.Write(n2);
            int s = n1;
            n1 = n2;
            n2 = s;
            
            //Console.WriteLine("hou");
        }
        static void Main(string[] args)
        {
            //RevOpt(12345);
            int n1 = 15; int n2 = 20;
            //int n1 = 5, n2 = 3, h, c;
            //Calc(n1, n2,out h,out c);



            //引用参数使用前必须赋值
            //Console.WriteLine("调用前------{0},{1}", n1, n2);
            //Swap(ref n1,ref n2);
            //Console.WriteLine("调用后------{0},{1}", n1, n2);
            Console.WriteLine(GetSum(5, 3));
            Console.WriteLine(GetSum(5,4,3,2,1));
            int[] a = new int[10];
            Console.WriteLine(GetSum(a));
        }
    }
}