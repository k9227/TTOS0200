using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Price);
        }
    }
    class Tehtava2
    {
        public static void TestTehtava2()
        {
            try
            {
                List<Product> products = new List<Product>();
                Product kalja = new Product("Kotimainen Olut", 0.82);
                Product gin = new Product("Kyrö Napue Gin", 39.79);
                products.Add(kalja);
                products.Add(gin);
                foreach (object o in products)
                {
                    Console.WriteLine(o);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
