using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class CheckUserChoice
    {
        private readonly SeeDescription _seeDescription;
        private readonly AddDescription _addDescription;
        private readonly RemoveDescription _removeDescription;
        
        public CheckUserChoice(SeeDescription seeDescription, AddDescription addDescription, RemoveDescription removeDescription)
        {
            _seeDescription = seeDescription;
            _addDescription = addDescription;
            _removeDescription = removeDescription;
        }
        
        public void checkUserChoice(string userChoice, List<string> listDescription)
        {
            string userChoiceFormatted = userChoice.ToUpper();

            switch (userChoice.ToUpper())
            {
                case "S":                    
                    _seeDescription.seeAllToDo(listDescription);
                    break;
                case "A":
                    Console.WriteLine("Enter the ToDo Description:");
                    string toDoDescription = Console.ReadLine();
                    _addDescription.AddToDoDescription(toDoDescription, listDescription);
                    break;
                case "R":
                    _removeDescription.RemoveToDo(listDescription);
                    break;
                default:
                    Console.WriteLine("Invalid Choice\n");
                    break;
            }
        }
    }
}
