using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS14_单例模式
{
    class Person
    {
        private string cName;
        private int nAge;

        public string CName { get => cName; set => cName = value; }
        public int NAge { get => nAge; set => nAge = value; }
        private Person (string cName,int nAge)
        {
            
            this.cName = cName;
            this.nAge = nAge;
        }

        public static Person GetPerson(string cname,int nage)
        {
            lock (obj)
            {
                if (psn == null)
                    //在构造前对临界点加锁
                {

                    psn = new Person(cname, nage);
                }
                else
                {
                    psn.cName = cname;
                    psn.nAge = nage;
                }
                return psn;
            }
        }

        //1.构造一个私有的静态类对象
        static private Person psn;
        //2.有且只有一个私有的构造函数
        //3.构造静态的全局访问点
        //4.定义一个静态临界点
        static object obj = new object();//定义一个静态的临界点
        static void Say()
        {
            Console.WriteLine("我叫{0}，今年{1}岁",psn.cName,psn.nAge);
        }
    }
}
