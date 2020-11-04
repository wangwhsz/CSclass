using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS15_继承
{
    class Student : Person
    {
        private string discipline;
        public string Discipline
        {
            get
            {
                return discipline;
            }
            set
            {
                discipline = value;
            }
        }
        public Student(string cName,int nAge,string Discipline) :base(cName,nAge)
        {
            //Console.WriteLine("Student被构造");
            this.Discipline = Discipline;
        }
        public override void Say()
        {
            base.Say();
            Console.WriteLine("系别{0}", Discipline);
            //Console.WriteLine("我是一个学生");
        }
    }
}
