using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class Administrator : IDisposable
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; }
        public int Age { get; set; }
        public int NumPhone { get; set; }

        public Administrator(string firstName, string secondName, int age, int numPhone)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            SecondName = secondName ?? throw new ArgumentNullException(nameof(secondName));
            FullName = FirstName + SecondName;
            Age = age;
            NumPhone = numPhone;
        }

        public void Add()
        {
            //Student student = new Student();
          //  Console.WriteLine("Участник добавлен" + student.ToString());
        }
        
        public void Dispose()
        {
            Console.WriteLine("Участник удален");
        }
       public new void ToString()
        {
            Console.WriteLine($"Имя администратора: {FullName} \nВозраст: {Age} \nНомер: {NumPhone} \n");
        }
    }
}
