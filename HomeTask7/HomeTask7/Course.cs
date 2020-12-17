using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class Course 
    { 
        public int NumCourse { get; set; }
        public string NameCourse { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public int NumOfStudent { get; set; }

        public Course(int numCourse, string nameCourse, string startDate, string finishDate, int numOfStudent)
        {
            NumCourse = numCourse;
            NameCourse = nameCourse ?? throw new ArgumentNullException(nameof(nameCourse));
            StartDate = startDate ?? throw new ArgumentNullException(nameof(startDate));
            FinishDate = finishDate ?? throw new ArgumentNullException(nameof(finishDate));
            NumOfStudent = numOfStudent;
        }

        public new void ToString()
        { 
            Console.WriteLine($"Курс: {NumCourse} \nНазвание курса: {NameCourse} \nДата начала курса: {StartDate} \nДата завершения курса: {FinishDate} \nКоличество студентов: {NumOfStudent} \n");
        }
    }
}
