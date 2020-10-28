using System;

namespace CS11_类的属性
{
    class Person
    {
        //姓名
        private string cName;
        public string Name
        {
            get { return cName; }
            //set { cName = value; }
        }

        private int nAge;
        public int Age
        {
            get { return nAge; }
            set
            {   nAge = value;  }
        }
        //带默认值的参数必须放在参数列表最后
        public Person(string cName,int nAge = 0)
        {
            this.cName = cName;
            this.nAge = nAge;
        }
        public void Say()
        {
            Console.WriteLine("姓名{0}，，，年龄{1}",this.Name,this.Age);
        }

    }
}