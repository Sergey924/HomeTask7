using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; }
        public int Age { get; set; }
        public int NumPhone { get; set; }

        public Teacher(string firstName, string secondName, int age, int numPhone) 
        {
            FirstName = firstName;
            SecondName = secondName;
            FullName = FirstName + SecondName;
            Age = age;
            NumPhone = numPhone;
        }

        

        public void AddHomeWork (string typeOfMaterial, string deadLine)
        {
            HomeWork homework = new HomeWork();
            homework.NumHomeWork = Console.ReadLine();
            homework.TypeOfMaterial = Console.ReadLine();
            homework.DeadLine = Console.ReadLine();

        }
        public new void ToString()
        {
            Console.WriteLine($"Имя преподователя: {FullName} \nВозраст: {Age} \nНомер: {NumPhone} \n");
        }
    }
}
