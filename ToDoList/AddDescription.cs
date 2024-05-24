using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class AddDescription
    {
        public void AddToDoDescription(string description, List<string> listDescription)
        {
            if (description != "")
            {
                // List<string> listDescription = new List<string>();
                if (listDescription.Contains(description))
                {
                    Console.WriteLine("The description must be unique\n");
                }
                else
                {
                    listDescription.Add(description);
                    Console.WriteLine($"ToDo successfully added: {description}\n");
                }
            }
            else
            {
                Console.WriteLine("The description cannot be empty\n");
            }

        }
    }
}
