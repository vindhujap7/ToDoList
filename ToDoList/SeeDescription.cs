using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoList
{
    public class SeeDescription
    {

        public void seeAllToDo(List<string> descriptionList)
        {
            int count = 1;
            if (descriptionList.Count > 0)
            {

                foreach (string description in descriptionList)
                {
                    Console.WriteLine($"{count}. {description}");
                    count++;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no descriptions added.\n");
            }
        }

    }
}
