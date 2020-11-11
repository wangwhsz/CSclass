using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CS16_索引属性
{
    class Program
    {
        // private protected public internal 
            // internal protected int db;
            static void Main(string[] args)
        {
            Person psn = new Person("zhangsan",5);
            //psn.Name = "lisi";
            //psn.Age = 100;
            psn["name"] = "lisi";
            psn["age"] = 100;
            psn.Say();
            Console.WriteLine("{0}", psn["name"]);
            
        }
    }
}
