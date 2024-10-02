using _75_Refactor74_Repository;
Products products = new Products();
ListStringPrinter listStringPrinter = new ListStringPrinter();
ListStringRepository productRepository = new ListStringRepository();
FilePathBilder filePathBilder = new FilePathBilder();


bool fileExists = File.Exists(filePathBilder.GetFileName());
if (!fileExists)
{
    Console.WriteLine("No File!!!. Get the number of products:");
    int productCount = int.Parse(Console.ReadLine());

    for (int i = 0; i < productCount; i++)
    {
        Console.WriteLine($"please give the name of products{i + 1}:");
        products.AddProduct(Console.ReadLine());

    }
    productRepository.save(products.productList, filePathBilder.GetFileName());

}
else
{
    // products.load();
    var productNames = productRepository.GetLinesStrings(filePathBilder.GetFileName());
    products.AddProducts(productNames);
    //products.PrintProductNames();
    listStringPrinter.Print(products.productList);
}

Console.WriteLine("Finished!");
Console.ReadLine();
