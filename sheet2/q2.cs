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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age*12; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return  weight; }
            set { weight = value; }
        }

        
        
    }
    internal static class Program
    {
        
        private static void Main(string[] args)
        {
            var mostafa = new Person();
            mostafa.Name = "mostafa";
            mostafa.Age = 19;
            Console.WriteLine(mostafa.Name);
            Console.WriteLine(mostafa.Age);


        }

    }
}
