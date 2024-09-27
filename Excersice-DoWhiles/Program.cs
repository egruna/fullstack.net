Console.WriteLine("Enter String More Than 10 Characters:");
string myString=Console.ReadLine();
while (myString.Length<10)
{
    Console.WriteLine("Not valid , More Than 10 Chars ...");
    myString = Console.ReadLine();
}

string userInput=string.Empty;
do
{
    Console.WriteLine("Entrat more than 3 char lenght");
    userInput = Console.ReadLine();
} while (userInput.Length<=3);


Console.WriteLine("Enter A Number for Tyoe from 0 to your number:");
int MaxCounter=int.Parse(Console.ReadLine());
int counter = 0;
while (counter < MaxCounter)
{
    Console.WriteLine(counter);
    counter++;
}
Console.ReadLine();