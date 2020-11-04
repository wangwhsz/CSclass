using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_索引属性
{
    class Person
    {
        //Console.WriteLine("{0}",1);
        private string cName;
        private string nAge;

        public string Name
        {
            get
            {
                return cName;
            }
            set
            {
                cName = value;
            }
        }
        public string Age
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
        //索引访问
        public string this[int index]
        {
            get
            {
                string cval = "";
                //cval = cName;
                switch (index)
                {
                    case 0: cval = Name;
                        break;
                    case 1: cval = Age;
                        break;
                }
                return cval;
            }
            set
            {
                switch (index) {
                    case 0:
                        Name = value;
                        break;
                    case 1:
                        Age = value;
                        break;
                }
            }
        }

        public Person(string cName, string nAge)
        {
            Age = nAge;
            Name = cName;
        }
        //public Person()
        //{
        //    Console.WriteLine("Person被构造");
        //    //CName = cname;
        //    //NAge = nage;
        //}
        public void Say()
        {
            Console.WriteLine("人:姓名{0} 年龄{1}", Name, Age);
        }

    }
}
