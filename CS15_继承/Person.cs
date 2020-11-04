using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_继承
{
    public class Person
    {
        private string cName;
        private int nAge;
        public string Name {
        get{
                return cName;
            }
            set
            {
                cName = value;
            }
        }
        public int Age
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
        public void Say()
        {
            Console.WriteLine("我叫{0}，今年{1}岁", Name, Age);

        }
        public Person(string cName,int nAge)
        {
            Name = cName;
            Age = nAge;
        }

    }
}
