
namespace MarysCandyShop
{
    internal class ProductsController
    {
        void AddProduct()
        {
            Console.WriteLine("Product name: ");
            string product = Console.ReadLine();
            int index = products.Count();
            products.Add(index, product.Trim());
        }

        void DeleteProduct(string message)
        {
            Console.WriteLine(message);
        }

        void UpdateProduct(string message)
        {
            Console.WriteLine(message);
        }

        void SaveProducts()
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
                {
                    foreach (KeyValuePair<int, string> product in products)
                    {
                        outputFile.WriteLine($"{product.Key}, {product.Value}");
                    }
                }
                Console.WriteLine("Products saved");

            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error saving products: " + e.Message);
            }
        }

        void LoadData()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Configuration.docPath))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        string[] parts = line.Split(',');
                        products.Add(int.Parse(parts[0]), parts[1]);
                        line = reader.ReadLine();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(divide);
            }
        }
    }
}
