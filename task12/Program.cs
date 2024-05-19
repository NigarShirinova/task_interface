using task12;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product("alma", 3, task12.Type.Groceries);
        Product product2 = new Product("iphone", 3000, task12.Type.Electronics);
        ProductCatalog catalog = new ProductCatalog();
        catalog.AddProduct(product1);
        catalog.AddProduct(product2);
        catalog.GetAllProductsByType(task12.Type.Groceries);
        catalog.GetAll();

    }
}