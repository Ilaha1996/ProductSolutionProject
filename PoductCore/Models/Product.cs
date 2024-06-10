namespace PoductCore.Models;

public class Product
{
    public static int counter;
    public int Id { get; set; } 
    public string Name { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }

    public Product(string name, double costprice, double salePrice)
    {
        Name = name;
        CostPrice = costprice;
        SalePrice = salePrice;
        Id = counter++;
    }

}
