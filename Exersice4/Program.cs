Console.Write("Enter Num 1:");
int num1=int.Parse(Console.ReadLine());
Console.Write("Enter Num 2:");
int num2=int.Parse(Console.ReadLine());


Console.WriteLine("Select +(A,a) or -(S,s) or *(M,m)");
var myOperator=Console.ReadLine();

if (myOperator =="A" || myOperator =="a" || myOperator == "+")
{
    printMessage(num1,num2, myOperator,num1+num2);
}else if (myOperator == "S" || myOperator == "s" || myOperator == "-")
{
    Console.WriteLine($"Menha Num {num1} , {num2} is:" + (num1 - num2));
}
else if (myOperator == "M" || myOperator == "m" || myOperator == "*")
{
    Console.WriteLine($"Zarb Num {num1} , {num2} is:" + (num1 * num2));
}
else
{
    Console.WriteLine("No Valid data");
}
 void printMessage(int num1, int num2, string myOperator, int result)
{
    Console.WriteLine($"{num1}+{myOperator}+{num2}={result}");
}

    Console.ReadLine();