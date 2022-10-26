using System;
using System.Reflection;

namespace index
{
   public class fruit
    {
        protected string color;
        protected string name;
    }

  public  class apple : fruit
    {
         public apple(string co, string n)
        {
            color = co;
            name = n;
        }

        public string getcolor()
        {
            return color;
        }

        public string getname()
        {
            return name;
        }
    }
    internal static class Program
    {
        
        private static void Main(string[] args)
        {
            var ap = new apple("red", "red apple");
            Console.WriteLine(ap.getname());
            
        }

    }
}
