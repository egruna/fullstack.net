int[,] myArray = new int[2,3];
myArray[0,0] = 0;
myArray[0,1] = 1;
myArray[0,2] = 2;
myArray[1,0] = 10;
myArray[1,1] =11;
myArray[1,2] = 12;
int row=myArray.GetLength(0);
int col=myArray.GetLength(1);
Console.WriteLine("With For");
for (int i = 0; i < row; i++)
{
    for(int j = 0; j < col; j++)
    {
        Console.WriteLine(myArray[i,j]);
    }
    
}

Console.WriteLine("With Foreach");
foreach (var item in myArray)
{
    Console.WriteLine(item);
}
Console.ReadLine();

