bool isExitSelectet = false;
List<string> toDolist = new List<string>();

while (!isExitSelectet)
{
   Console.WriteLine();
   Console.WriteLine("[S]ee All ToDo");
   Console.WriteLine("[A]dd a ToDo");
   Console.WriteLine("[R]emove ToDo");
   Console.WriteLine("[E]xit to do App");
  

  char UserInput = Console.ReadKey().KeyChar;
   // '  for Char and " for string

    switch (UserInput)
    {
        case 'S':
        case 's':
            SeeAllToDo();
            break;
        case 'A':
        case 'a':
            AddToDo();
            break;
        case 'R':
        case 'r':
            RemoveToDo();
            break;
        case 'E':
        case 'e':
           isExitSelectet = true;
            break;
        default:
            Console.WriteLine("Not Valid Data");
            UserInput = Console.ReadKey().KeyChar;
            break;
    }

}



void SeeAllToDo()
{
    if (!allowContinue())
        return;
   
    
    writeWithWhiteSpace("ToDo Item Are:");

    for (int i = 0; i < toDolist.Count; i++) 
    {
        string? item = toDolist[i];
        Console.WriteLine($"{i+1}:{item}");
    }
}

void AddToDo()
{
    string inputMessage=string.Empty;
    do
    {
        writeWithWhiteSpace("Enter ToDo To Add:");
        inputMessage = Console.ReadLine();
    } while (isValidMessage(inputMessage));
             toDolist.Add(inputMessage); 
}

void RemoveToDo()
{
    if (!allowContinue())
    {
        return;
    }

    Console.ReadLine();
    bool isValidMessage = false;
    while (!isValidMessage)
    {

        writeWithWhiteSpace("Tasks in ToDo List:");
        SeeAllToDo();
        Console.Write("Enter Index to Remove:");
        string inputIndex = Console.ReadLine();
        if (inputIndex == "")
        {
            Console.WriteLine("invalid Index: can not be empty.");
            continue;
        }
        if (int.TryParse(inputIndex, out int index))
        {
            if (index >= 1 && index <= toDolist.Count)
            {
                isValidMessage = true;
                string toDOForDelete = toDolist[index - 1];
                toDolist.RemoveAt(index - 1);
                Console.WriteLine($"{toDOForDelete} deleted!");
            }
            else
            {
                Console.WriteLine("Invalid Index: Not in range!");
            }
        }
        else
        {
            Console.WriteLine("invalid Index: index format is invalid.");
        }
    }

}


bool allowContinue()
{
    if (toDolist.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine("No Task In ToDo List:");
        return false;
    }
    else
    {
        return true;
    }
}

void writeWithWhiteSpace(string text)
{
    Console.WriteLine();
    Console.WriteLine(text);
}

bool isValidMessage(string message)
{
    bool isValid = true;
    if (message == "")
    {
        Console.WriteLine("invalid : can not be empty:");
        isValid= false;
    }
    else if (toDolist.Contains(message))
    {
        Console.WriteLine("invalid: New Task Dosnt be Dublicated!");
        isValid= false;
    }
    return isValid;
}

bool isValidForRemove(string message)
{

}