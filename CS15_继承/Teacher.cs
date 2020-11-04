using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_继承
{
    class Teacher : Person
    {
        private double nSalary;
        public double Salary
        {
            get
            {
                return nSalary;
            }
            set
            {
                nSalary = value;
            }
        }
        public Teacher(string cName,int nAge,double nSalary):base(cName,nAge)
        {
            Salary = nSalary;

            //Console.WriteLine("工资{0}", Salary);
        }
        public override void  Say()
        {
            base.Say();
            Console.WriteLine("我是一个教师");
        }
        //~Teacher()
        //{
        //    Console.WriteLine("teacher被销毁");
        //}
    }
}
