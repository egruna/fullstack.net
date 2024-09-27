List<int> ints = new List<int> { 12,121,32,4,56,6,7,8,92,10,11};
int oddNum = 0;
int evenNum ;
oddNum= oddEvenCounter(ints,out evenNum);
Console.WriteLine($"odd are:{oddNum}");
Console.WriteLine($"Even  are:{evenNum}");
//foreach (int i in ints)
//{
//    if (i%2== 0)
//    {
//        evenNum++;
//        Console.WriteLine(i);
//    }
//    else
//    {
//        oddNum++;
//        Console.WriteLine(i);
//    }

//}
//Console.WriteLine(evenNum);
//Console.WriteLine(oddNum);
//Console.WriteLine("-------");
int oddEvenCounter(List<int> input,out int evenNum)
{
    evenNum = 0;
   int oddNum = 0;
    foreach (int i in input)
    {
        if (i % 2 == 0)
        {
            evenNum++;
        }
        else
        {
            oddNum++;
        }
        

    }
    return oddNum;
}

Console.WriteLine("--- out variables in Method ---");
int yourAge;
if(int.TryParse(Console.ReadLine(),out yourAge))
{
    Console.WriteLine($"Your age is {yourAge}");
}
else
{
    Console.WriteLine("Invalid Char!!!");
}
//Console.WriteLine(int.TryParse(Console.ReadLine(), out yourAge));
Console.ReadLine();