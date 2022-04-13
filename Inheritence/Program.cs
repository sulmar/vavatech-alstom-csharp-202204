using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            Product product1 = new Product();
            product1.name = "Torebka";
            product1.color = "Black";
            product1.price = 200;
            product1.size = Size.M;

            product1.Display();

            Product product2 = new Product();
            product2.name = "Okulary słoneczne";
            product2.color = "Red";
            product2.price = 300;
            product2.size = Size.L;

            product2.Display();

            BigSizeProduct product3 = new BigSizeProduct();
            product3.name = "Lodówka";
            product3.color = "White";
            product3.price = 2000;
            product3.weight = 20;

            product3.Display();

            Service service = new Service();
            service.name = "Dostawa";
            service.price = 10;
            service.duration = TimeSpan.FromDays(3);

            service.Display();


            shoppingCart.Add(product1);
            shoppingCart.Add(product2);
        }
    }

    class ShoppingCart
    {
        public List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            products.Remove(product);
        }
    }

    // Dziedziczenie (inheritance)

    // Klasa bazowa - fundament dla klas potomnych, posiada wspólne cechy i metody

    class Base
    {
        public DateTime createDate;
        public DateTime modifiedDate;
    }

    class Item : Base
    {
        public int id;
        public string name;
        public decimal price;

        public void Display()
        {
            Console.Write($"{id} {name} {price} - ");
        }
    }

    // Klasa potomna - Klasa Product dziedziczy po klasie bazowej Item
    class Product : Item
    {
        public string color;
        public Size size;

        public void Display()
        {
            base.Display();

            Console.WriteLine($"{color} {size}");
        }
    }

    class BigSizeProduct : Product
    {
        public int weight;

        public void Display()
        {
            base.Display();

            Console.WriteLine(weight);
        }
    }

    // Klasa potomna - Klasa Serviec dziedziczy po klasie bazowej Item
    class Service : Item
    {
        public TimeSpan duration;

        public void Display()
        {
            base.Display();
            Console.WriteLine($"{duration}");
        }
    }

    enum Size
    {
        S,
        M,
        L,
        XL
    }


}
