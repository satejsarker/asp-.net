using System;
using Newtonsoft.Json;

namespace aspApp
{
    class Program
    {
        static void Main(string[] args)
        {
           //creating product object
           var product1=new Product{ID=11,Name="satej",Price=1.99};
           //serialize the product object to JSON string
           var jsonString=JsonConvert.SerializeObject(product1);
           System.Console.WriteLine(jsonString);
           // Deserialize the JSON string back to product object
           var product2=JsonConvert.DeserializeObject<Product>(jsonString);
           System.Console.WriteLine($"the product id is {product2.ID}");
            System.Console.WriteLine($"the product Name is {product2.Name}");
             System.Console.WriteLine($"the product price  is {product2.Price}");
        }
    }
    //create model class
  class Product{
      public int ID{get;set;}
      public string Name{get;set;}
      public double Price{get;set;}

  }
}
