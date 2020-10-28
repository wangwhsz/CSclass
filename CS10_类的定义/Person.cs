using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10_类的定义
{
    class Person
    {
        private string cName;
        private int nAge;
        internal long idCard;

        public int Age { set { nAge = value; } get { return nAge; } }
        //public int NAge { get { return nAge}; set => nAge = value; }
        //public string CName { get => cName; set => cName = value; }

        public void Say()
        {
            Console.WriteLine("姓名：{0}\t年龄：{1}", cName, nAge);
        }
        public Person(string cName = "邵市长", int nAge = 18)
        {
            this.cName = cName;
            this.nAge = nAge;
        }
        //public Person()
        //{
        //    cName = "邵市长";
        //    nAge = 18;
        //}
    }
}
