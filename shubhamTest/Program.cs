using shubhamTest.Data;

namespace shubhamTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Shhubham is hard working man");
            Console.WriteLine("_______________________________");
            Console.WriteLine("press shops to get coffies");
          

            while (true)
            {
                var command = Console.ReadLine();
                if (string.Equals("quit", command, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (string.Equals("shops", command, StringComparison.OrdinalIgnoreCase))
                {
                    var dataProvider = new Tesla();
                    var shops = dataProvider.LoadShops();

                    foreach (var shop in shops)
                    {
                        Console.WriteLine($"City: {shop.city}, Cups in stock: {shop.cupsInStock}");
                    }
                }
            }
        }
    }
}
