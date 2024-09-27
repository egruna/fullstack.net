

List<int> listnumber = new List<int>();
Console.Write("Number of item in List:");
Console.WriteLine(listnumber.Count);
int sum = 0;
//Console.Write("Enter A Number to Add ... :" );
int inputNumber = 0;
do
{
    Console.WriteLine($"add Number {listnumber.Count+1}");
    inputNumber= int.Parse(Console.ReadLine());
    listnumber.Add(inputNumber);
    sum += inputNumber;
} while (sum<1000);
foreach (var item in listnumber)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Totall Number in this List is {listnumber.Count}");
Console.WriteLine("first item is : " + listnumber[0]);
listnumber.Add(999);
Console.WriteLine($"Totall Number in this List is {listnumber.Count}");
Console.WriteLine("last item is : "+listnumber[listnumber.Count-1]);
listnumber.Remove(999);
Console.WriteLine("last item is : " + listnumber[listnumber.Count - 1]);
listnumber.RemoveAt(0);
Console.WriteLine("first item is : " + listnumber[0]);
Console.WriteLine(listnumber.Count);
Console.WriteLine(listnumber.Capacity);
//  برای هر 4 ایتم یک ارایه 4 تایی می سازد اگر بیشتر شد سپس 8 تایی و سپس 16 تایی و ....
Console.ReadLine();