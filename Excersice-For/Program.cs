Console.WriteLine("Enyer your number: ");
int num =int.Parse(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    if (i % 5 == 0)
    {
       //Console.WriteLine("i % 5 == 0 is correct");
        Console.WriteLine("--");
        continue;
    }
    else if (i == 14) 
    {
      break;
    }
    Console.WriteLine(i);
}

Console.ReadLine();