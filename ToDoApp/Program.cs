

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

void RemoveToDo()
{
    Console.ReadLine();
    bool isValidMessage=false;
    while (!isValidMessage) 
    { 
    if(toDolist.Count == 0)
    {   
        Console.WriteLine("No Task In ToDo List:");
    }
    Console.WriteLine("Tasks in ToDo List:");
    SeeAllToDo();
    Console.Write("Enter Index to Remove:");
    string inputIndex=Console.ReadLine();
    if(inputIndex == "")
    {
        Console.WriteLine("invalid Index: can not be empty.");
            continue;
    }
    if(int.TryParse(inputIndex, out int index))
    {
        if (index >= 1 && index <= toDolist.Count) 
        {
                isValidMessage = true;
                string toDOForDelete=toDolist[index-1];
            toDolist.RemoveAt(index-1);
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

void SeeAllToDo()
{
    Console.ReadLine();
    for (int i = 0; i < toDolist.Count; i++) 
    {
        string item = toDolist[i];
        Console.WriteLine($"{i+1}:{item}");
    }
}

void AddToDo()
{
    Console.ReadLine();
    bool isValidTask=false;
    while (!isValidTask)
    {
       Console.WriteLine("Please Enter Neew Task:");
       string newToDo=Console.ReadLine();
       if (newToDo == "")
       {
           Console.WriteLine("Please ENter a New Task.");
       }
       else if (toDolist.Contains(newToDo))
       {
           Console.WriteLine("New Task Dosnt be Dublicated!");
       }
       else
       {
           toDolist.Add(newToDo);
           isValidTask = true;
       }
       
    }
}


Console.ReadLine();


