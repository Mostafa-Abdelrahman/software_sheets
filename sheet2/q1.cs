using System;
using System.Reflection;

namespace index
{
    class Person
    {
        private string name;
        private int age;
        private double height;
        private double weight;

       public Person(string Name, int Age, double Height, double Weight)
        {
            name = Name;
            age = Age;
            height = Height;
            weight = Weight;
        }
        public  string GetName()
        {
            return name;
        }

         public int GetAge()
         {
             return age * 12;
         }
    }
    internal static class Program
    {
        
        private static void Main(string[] args)
        {
            Person mostafa = new Person("mostafa", 19, 175, 57);
            Console.WriteLine(mostafa.GetName());
            Console.WriteLine(mostafa.GetAge());
            
            
        }

    }
}
