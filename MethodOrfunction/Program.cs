
Console.WriteLine("[S]ee All ToDo");
Console.WriteLine("[A]dd a ToDo");
Console.WriteLine("[R]emove ToDo");
Console.WriteLine("[E]xit to do App");
var userInput=Console.ReadLine();
if (userInput == "S")
{
    Console.WriteLine("User Select:"+"[S]ee All ToDo");
}else if (userInput == "A")
{
    printMessage("[A]dd a ToDo");
}
else if (userInput == "R")   
{
    printMessage("[R]emove ToDo");
}
else if(userInput =="E")
{
    printMessage("[E]xit to do App");
}
else
{
    printMessage("None Of S,A,R,E");
}

void printMessage(string v)
{
    Console.WriteLine($"User Select:{userInput}::" + v);
}

Console.ReadLine();
