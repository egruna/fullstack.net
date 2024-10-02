using _74_SRP_TextFileLoadAndWrite;
Products products = new Products();

bool fileExists = File.Exists(products.GetFileName());
if (!fileExists)
{
     Console.WriteLine("No File!!!. Get the number of products:");
    int productCount=int.Parse(Console.ReadLine());

    for(int i = 0; i < productCount; i++)
    {
        Console.WriteLine($"please give the name of products{i+1}:");
        products.AddProduct(Console.ReadLine());

    }
    products.save();

}
else
{
    products.load();
    products.PrintProductNames();
}

Console.WriteLine("Finished!");
Console.ReadLine();
