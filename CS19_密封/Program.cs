using System;

namespace CS19_密封
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("1");
            Person psn = new Person();
            Person stu = new Student();
            psn.Say();
            stu.Say();
            Person bgs = new BStudent();
            bgs.Say();
        }
    }
}