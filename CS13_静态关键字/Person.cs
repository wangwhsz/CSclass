using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS13_静态修饰符
{
    static class Person
    {
        static string cName;
        static int nAge;
        static string Name
        {
            get
            {
                return cName;
            }
        }
        public static int Age 
        {
            get
            {
                return nAge;
            }
            set
            {
                nAge = value;
            }
        }
        static Person()
        {
            //Person.cName = cName;
            //Person.Age = nAge;
        }
        //public static Person()
        //{
            //this.cName = cName;
            //Age = nAge;
        //}
        static public void Say()
        {
            Console.WriteLine("姓名{0}，年龄{1}",Person.cName,Person.Age);
            
        }
    }
}
