using System;

namespace HomeTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Course CSharpBase = new Course(1, "SCharpBaze", "01.11.2020", "01.12.2020", 5);
            CSharpBase.ToString();

            Administrator administrator1 = new Administrator("Алёна"," Новикова",31,056484);
            administrator1.ToString();

            Teacher teacher1 = new Teacher("Александр", " Свириденко", 25, 549805465);
            teacher1.ToString();

            Student student1 = new Student("Сергей"," Данилин",19,0448465);
            student1.ToString();

            
            Student student2 = new Student("Валентин", " Павлик", 19, 0448465);
            student2.ToString();

            Student student3 = new Student("Евгений", " Яков", 19, 0448465);
            student3.ToString();


            Student student4 = new Student("Виталий", " Шипотько", 19, 0448465);
            student4.ToString();


            Student student5 = new Student("Виктория", " Лагута", 19, 0448465);
            student5.ToString();

            

            teacher1.AddHomeWork("Презентация", "15.11.2020");





        }
    }
}
