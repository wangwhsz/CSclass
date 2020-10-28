using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10_类的定义
{
    /// <summary>
    /// 人员信息
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            per1.Say();
            Person per2 = new Person("邵省长",19);
            per2.Age = 100;
            per2.Say();
            //邵敏彳亍！
        }
    }
}
