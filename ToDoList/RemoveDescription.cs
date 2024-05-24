using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class RemoveDescription
    {
        private readonly SeeDescription _seeDescription;
        public RemoveDescription(SeeDescription seeDescription)
        {
            _seeDescription = seeDescription;
        }
        public void RemoveToDo(List<string> listDescription)
        {

            if (listDescription.Count <= 0)
            {
                Console.WriteLine("There is no to do list\n");
                return;
            }

            Console.WriteLine("Enter the index of string that needs to removed");
            _seeDescription.seeAllToDo(listDescription);
            string userInputIndex = Console.ReadLine();
            int index;
            if (userInputIndex == "")
            {
                Console.WriteLine("Index cannot be empty");
                return;
            }
            if ((int.TryParse(userInputIndex, out index)) && (index > 0) && (index < listDescription.Count))
            {
                int indexToBeRemoved = index - 1;
                Console.WriteLine(indexToBeRemoved);
                listDescription.Remove(listDescription[indexToBeRemoved]);
                Console.WriteLine($"The selected index {index} is removed.");
                _seeDescription.seeAllToDo(listDescription);
            }
            else
            {
                Console.WriteLine("Please enter a valid index");
            }

        }
    }
}
