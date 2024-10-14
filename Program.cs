//1ci task
namespace Product_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Tshirt", "Koton", 30);
            product.PrintInfo();
            /*Product[] products = new Product[]
            {
                new Product("Telefon", "Samsung", 999.99),
                new Product("Laptop", "Dell", 1500.00),
                new Product("Qulaqlıq", "Apple", 299.99),
                new Product("Televizor", "LG", 850.00)
            };
            double minPrice = 300.00;
            double maxPrice = 1000.00;
            Product[] Mehsullar = QiymetMehsul (products, minPrice, maxPrice);
            }
            foreach (Product product in QiymetMehsul )
            {
                product.ShowProductInfo(); 
            }
            static  Product[] QiymetMehsul(string[] args, double minPrice, double maxPrice)
            {
                Product[] QiymetMehsul = products
                .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
                .ToArray();

                return QiymetMehsul;
            }*/
        }
    }
}
