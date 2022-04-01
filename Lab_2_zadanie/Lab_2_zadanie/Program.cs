using System;
using System.Collections.Generic;

namespace Lab_2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller treacher = new Seller("Jan Kowalski", 50);

            Buyer buyer1 = new Buyer("Jaś Fasola 1", 25);
            Buyer buyer2 = new Buyer("Jaś Fasola 2", 21);
            Buyer buyer3 = new Buyer("Jaś Fasola 3", 23);

            buyer1.AddProduct(new Fruit("Apple", 6));
            buyer1.AddProduct(new Meat("Fish", 0.5));

            Person[] persons = { treacher, buyer1, buyer2, buyer3 };

            Product[] products = {
                new Fruit("Apple", 1000),
                new Fruit("Banana", 700),
                new Fruit("Orange", 500),
                new Meat("Fish", 100.0),
                new Meat("Beef", 75.0)
            };

            Shop shop = new Shop("Super Market", persons, products);

            shop.Print();
        }
    }

    interface IThing
    {
        string Name { get; set; }
    }

    abstract class Product : IThing
    {
        private string name;
        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Product(string name)
        {
            Name = name;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine(prefix + "product's name:" + Name);
        }
    }

    class Fruit : Product
    {
        private int count;
        public int Count { get => count; set { count = value; } }
        public Fruit(string name, int count) :base(name)
        {
            Name = name;
            Count = count;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Fruit's name: " + Name + " (" + Count + " fruits)");
        }

    }

    class Meat : Product
    {
        private double weight;
        public double Weight
        {
            get => weight;
            set
            {
                weight = value;
            }
        }
        public Meat(string name, double weight) : base(name)
        {
            Name = name;
            Weight = weight;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Meat's name: " + Name + "; (" + Weight + "kg)");
        }
    }


    class Person : IThing
    {
        private string name;
        private int age;
        public int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Print(string prefix)
        {
            Console.WriteLine(prefix + "Person's name: " + Name + "; Person's age:" + Age);
        }
    }

    class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Seller's name:" + Name + "; Seller's age:" + Age);
        }
    }

    class Buyer : Person
    {
        List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }
        public void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }

        public override void Print(string prefix)
        {
            string productList = "";
            Console.WriteLine(prefix + "Buyrs's name: " + Name + "; buyer's age:" + Age + "\n" + productList);
            foreach (Product p in tasks)
            {
                p.Print("\t \t");
            }

        }
    }

        class Shop : IThing
        {
            private string name;
            public string Name { get => name; set { name = value; } }
            private Person[] people;
            private Product[] products;

            public Shop(string name, Person[] people, Product[] products)
            {
                Name = name;
                this.people = people;
                this.products = products;
            }

            public void Print()
            {
                Console.WriteLine("Shop: " + Name);
                Console.WriteLine("-- People: --");
                foreach (Person p in people)
                {
                    p.Print("\t");
                }
                Console.WriteLine("-- Products: --");
                foreach (Product p in products)
                {
                    p.Print("\t");
                }
            }



        }
    
}
