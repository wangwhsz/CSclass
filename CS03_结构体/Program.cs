using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS03_结构体
{
    class Program
    {
        struct Student
        {
            public string cNum;
            public string cName;
            public int nGrade;
        }
        static void Main(string[] args)
        {
            Student stu01, stu02;
            stu01.cNum = "20190151054";
            stu01.cName = "WangzyaaaA";
            stu01.nGrade = 2;
            stu02 = stu01;
            Console.WriteLine("{0}{1}{2}", stu02.cNum, stu02.cName, stu02.nGrade);
            Console.ReadLine();

        }
    }
}

