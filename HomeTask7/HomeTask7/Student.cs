
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class Student 
    {
        public string FirstName { get; set; }
        public string SecondName {get;set;}
        public int Age { get; set; }
        public int NumPhone { get; set; }
        public string FullName { get; }

        public Student(string firstName, string secondName, int age, int numPhone) 
           
             
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            NumPhone = numPhone;
            FullName = FirstName + SecondName;
        }

       

       

        public new void ToString()
        {
            Console.WriteLine($"Имя студента: {FullName} \nВозраст: {Age} \nНомер: {NumPhone} \n");
        }
    }
}
