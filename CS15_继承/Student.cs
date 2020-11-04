using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS15_继承
{
    class Student:Person
    {
        public string cDiscipline;
        public string CDiscipline {
            get
            {
                return cDiscipline;
            }
            set
            {
                cDiscipline = value;
            }
        }
        public Student(string cName,int nAge, string CDiscipline):base(cName,nAge)
        {
            base.Say();

        }

    }
}
