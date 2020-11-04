using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS16_索引属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Person psn = new Person("zhangsan","5");
            psn.Name = "lisi";
            psn.Age = "100";
            psn.Say();
        }
    }
}
