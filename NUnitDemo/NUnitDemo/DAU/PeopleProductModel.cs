using NUnitDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo.DAU
{
    class PeopleProductModel
    {

        public Person[] Person = new Person[]
        {
            new Person{ ID=1,Name="Manish",Age=25,
                Product = new Product[]
                        { new Product(){ Name="Laptop",Description="HP",Price=1000 } } },
            new Person{ ID=2,Name="Yogesh",Age=33,
                Product = new Product[]
                             { new Product(){ Name="Laptop",Description="HP",Price=1000 }, new Product(){ Name="Mobile",Description="Samsung", Price=10000} } },
            new Person{ ID=3,Name="Priya",Age=29,
                Product = new Product[]
                        { new Product(){ Name="Mobile",Description="Moto",Price=10000 },new Product(){ Name="PC",Description="Dell",Price=10000 } } },
        };

        public Person[] GetClients()
        {
            Person[] client = new Person[]
           {
            new Person{ ID=1,Name="Manish",Age=25},
            new Person{ ID=2,Name="Yogesh",Age=33},
            new Person{ ID=3,Name="Priya",Age=29},
            new Person{ ID=4,Name="Archita",Age=6},
           };
            return client;
        }

        public Product[] GetProducts()
        {
            Product[] Product = new Product[]
            {
                new Product{ PID=1,ID=1,Name="HP",Description="Laptop",Price=1000},
                new Product{ PID=2,ID=1,Name="Google",Description="Laptop",Price=700},
                new Product{ PID=3,ID=2,Name="Acer",Description="Laptop",Price=1000},
                new Product{ PID=4,ID=5,Name="Asus",Description="Laptop",Price=800},
                new Product{ PID=5,ID=5,Name="Microsoft",Description="Laptop",Price=900},
                new Product{ PID=6,ID=6,Name="Apple",Description="Laptop",Price=1100},
                new Product{ PID=7,ID=3,Name="HP",Description="Laptop",Price=600},
                new Product{ PID=8,ID=3,Name="Dell",Description="Laptop",Price=950},
            };
            return Product;
        }
    }
}
