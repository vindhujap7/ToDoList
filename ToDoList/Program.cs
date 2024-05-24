using ToDoList;

string userChoice = null;
List<string> listDescription = new List<string>();

AddDescription addDescription = new AddDescription();
SeeDescription viewDescription = new SeeDescription();
RemoveDescription removeDescription = new RemoveDescription(viewDescription);
CheckUserChoice choice = new CheckUserChoice(viewDescription, addDescription, removeDescription);
do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S] ee all TODOs");
    Console.WriteLine("[A] dd a TODO");
    Console.WriteLine("[R] emove a TODO");
    Console.WriteLine("[E] xit");
    userChoice = Console.ReadLine();
    if (userChoice.Equals("E", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }    
    choice.checkUserChoice(userChoice, listDescription);
} while (userChoice != null);


