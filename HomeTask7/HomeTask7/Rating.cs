using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class Rating 
    {
        public int Score { get; set; }
        public string TypeOfMaterial { get; set; }
        public string FullNameStudent { get; set; }
        public string DateOfCheck { get; set; }

        public Rating(int score, string typeOfMaterial, string fullNameStudent, string dateOfCheck) 
        {
            Score = score;
            TypeOfMaterial = typeOfMaterial;
            FullNameStudent = fullNameStudent;
            DateOfCheck = dateOfCheck;
        }

        public new void ToString()
        {
            Console.WriteLine($"Имя студента: {FullNameStudent} \nТип материала: {TypeOfMaterial} \nОценка: {Score} \nДата проверки: {DateOfCheck} \n");
        }
    }
}
