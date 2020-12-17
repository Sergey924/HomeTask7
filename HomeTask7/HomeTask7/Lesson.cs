using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class Lesson 
    {
        public int NumLesson { get; set; }
        public string DateLesson { get; set; }
        public string TimeLesson { get; set; }
        public string Topic { get; set; }

        public Lesson(int numLesson, string dateLesson, string timeLesson, string topic)
        {
            NumLesson = numLesson;
            DateLesson = dateLesson;
            TimeLesson = timeLesson;
            Topic = topic;
        }

        public new void ToString()
        {
            Console.WriteLine($"Номер занятия: {NumLesson} \nТема: {Topic} \nДата заняти: {DateLesson} \nВремя занятия: {TimeLesson} \n");
        }
    }
}
