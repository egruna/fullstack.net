namespace _75_Refactor74_Repository;
public class Products
{
    // لیستی برای نگهداری محصولات
    public List<string> productList = [];
    public void AddProduct(string productName)
    {
        if (isvalidProductName(productName))
        {
            productList.Add(productName);
        }
        else
        {
            Console.WriteLine("Invalid Product Name!");
        }
    }

    public void AddProducts(List<string> products)
    {
        foreach (var productName in products) 
        {
            AddProduct(productName);
        }
    }

    // ولیدیتور درون کلاس باشد هم بهتر است و نیازبه ریفکتور ندارد
    private bool isvalidProductName(string productName) =>
       !string.IsNullOrEmpty(productName) && productName.Length > 2 && productName.Length < 100;  
}
