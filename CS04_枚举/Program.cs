using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace CS04_枚举
{
    class Program
    {
        public enum Status
        {
            录取,
            肄业,
            毕业

        }
        static void Main(string[] args)
        {
            Status stuZT;
            stuZT = Status.录取;
            switch (stuZT)
            {
                case Status.录取:
                    Console.WriteLine("该生已" + stuZT.ToString());
                    break;
                case Status.肄业:
                    Console.WriteLine("该生已" + stuZT.ToString());
                    break;
                case Status.毕业:
                    Console.WriteLine("该生已" + stuZT.ToString());
                    break;
            }
            int stuIndex = 2;
            switch (stuIndex)
            {
                case (int)Status.录取:
                    Console.WriteLine("该生已录取");
                    break;
                case (int)Status.肄业:
                    Console.WriteLine("该生已肄业");
                    break;
                case (int)Status.毕业:
                    Console.WriteLine("该生已毕业");
                    break;
            }
            string strStatus = "毕业";
            stuZT = (Status)Enum.Parse(typeof(Status), strStatus);
            Console.WriteLine("该生已" + Enum.GetName(typeof(Status), stuZT));

        }
    }
}