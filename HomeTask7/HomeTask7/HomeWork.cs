using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    class HomeWork 
    {
        public string NumHomeWork { get; set; }
        public string TypeOfMaterial { get; set; }
        public string DeadLine { get; set; }

       

        public new void ToString()
        {
            Console.WriteLine($"Номер д/з {NumHomeWork} \nТип: д/з {TypeOfMaterial} \nКрайний срок: {DeadLine} \n");
        }

    }
}
