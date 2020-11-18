using System;

namespace CS19_密封
{ 
    public class Student:Person
    {
        public sealed override void Say()
        {
            // base.Say();
            Console.WriteLine("学生");
        }
    }
}