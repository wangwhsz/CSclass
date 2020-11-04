using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Person psn = new Person("ren", 1);
            Person stu = new Student("张三",15,"cs");
            Person tcr = new Teacher("wangwu",30,4000);
            psn.Say();
            stu.Say();
            tcr.Say();
            Console.WriteLine("{0}");

        }
    }
}
