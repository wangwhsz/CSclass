using System;

namespace CS21_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            try
            {
                Console.WriteLine("输入两个整数");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"{a}/{b}={a/b}");
                Console.WriteLine("你好 处理完毕");
            }
            catch (Exception e)
            {
                
                // Console.WriteLine("出错");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Message);
                
                // throw;
            }
            finally
            {
                Console.WriteLine("做完了");
            }
        }
    }
}