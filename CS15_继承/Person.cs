using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_继承
{
    class Person
    {
        //Console.WriteLine("{0}",1);
        private string cName;
        private int nAge;

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
        /// <summary>
        /// 析构函数
        /// </summary>
        /// <param name="cName"></param>
        /// <param name="nAge"></param>
        //~Person()
        //{
        //    Console.WriteLine("person 被销毁");
        //}
        public Person(string cName,int nAge)
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
        public virtual void Say()
        {
            Console.WriteLine("人:姓名{0} 年龄{1}",Name,Age);
        }

    }
}
