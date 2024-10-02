

namespace _74_SRP_TextFileLoadAndWrite;

public class Products
{
    // لیستی برای نگهداری محصولات
    private List<string> products = new();

    public void AddProduct(string productName)
    {
        if (isvalidProductName(productName)) 
        {
            products.Add(productName);
        } 
        else
        {
            Console.WriteLine("Invalid Product Name!");
        } 
    }

    private bool isvalidProductName(string productName)=>
       !string.IsNullOrEmpty(productName) && productName.Length > 2 && productName.Length<100 ;

    public void save()
    {
        //  نحوه نوشتن در فایل تکست
        System.IO.File.WriteAllLines(GetFileName(),products);
    }

    public void load() 
    {
        var lines= System.IO.File.ReadAllLines(GetFileName());
        foreach (var line in lines) 
        {
            AddProduct(line);
        }
    }

    public string GetFileName() => "productNames.txt";

    public void PrintProductNames()
    {
        string productFormated = string.Join(" , ", products);
        Console.WriteLine(productFormated); 
    }
    
}



