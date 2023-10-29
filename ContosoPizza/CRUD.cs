using ContosoPizza.Date;
using ContosoPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContosoPizza
{
    public class CRUD
    {
      
        string Name;
        Decimal Price;
        public void createProduct()
        {
            Console.WriteLine("Enter Data Product");
            Console.WriteLine("Enter the product name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the product price");
            Price = Convert.ToDecimal(Console.ReadLine());

            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {
                Product product = new Product();

                product.Name = Name;
                product.Price = Price;
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
        public void readProduct()
        {
            
            
            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {


                var products = from product in db.Products orderby product.Name
                               select product;

              foreach (Product p in products) {
                    Console.WriteLine($"Id:     {p.Id}");
                    Console.WriteLine($"Name:   {p.Name}");
                    Console.WriteLine($"Price:     {p.Price}");
                }


            }
        }
        public void updateProduct()
        {
            Console.WriteLine("Enter Data Product");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the product name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the product price");
            Price = Convert.ToDecimal(Console.ReadLine());

            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {
                Product product = new Product();

                var pizzaProduct = db.Products.Where(p => p.Name == Name).FirstOrDefault();

                if (pizzaProduct is Product)
                {

                    product.Name = Name; 
                    product.Price = Price;
                }
                db.SaveChanges();
            }
        }
        public void deleteProduct()
        {
            Console.WriteLine("Enter Data Product");
            Console.WriteLine("Enter the product name");
            Name = Console.ReadLine();

            using (ContosoPizzaContext db = new ContosoPizzaContext())
            {
                Product product = new Product();

                var pizzaProduct = db.Products.Where(p => p.Name == Name).FirstOrDefault();

                if (pizzaProduct is Product)
                {
                    db.Remove(pizzaProduct);
                }
                db.SaveChanges();
            }
        }
    }
}
