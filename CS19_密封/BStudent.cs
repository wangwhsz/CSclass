using System;

namespace CS19_密封
{
    public class BStudent:Student
    {
        public void Say()
        {
            base.Say();
            Console.WriteLine("大学生");
        }
    }
}