using System;
using System.Reflection;
using Upcasting.Models;

namespace Upcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Orange();
            Pineapple pineapple = new Pineapple();
            Fruit[] Basket = new Fruit[]
            {
           new Apple{ Price =10, Sort="Quba", VitaminA=5, VitaminB=6 },
           new Pineapple{ Price =10, Sort="xarici", VitaminD=7, VitaminE=8 },
           new Orange{ Price =10, Sort="lenkeran", VitaminC=100 }
            };


          
            
            foreach(var fruit in Basket)
            {
               
                    Type type = fruit.GetType();
                    

                   
                Console.WriteLine($"type: {type.Name}");
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
                foreach (var field in fields)
                {

                    var value = field.GetValue(fruit);

                    Console.WriteLine($"{field.Name}: {value}");
                }
                FieldInfo[] baseFields = typeof(Fruit).GetFields(BindingFlags.Public | BindingFlags.Instance);

                Console.WriteLine($"Price: {fruit.Price}");
                Console.WriteLine($"Sort: {fruit.Sort}");
               


            }


            
        }



    }
}



