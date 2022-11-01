using System;
 namespace index
{


    interface  Shape
    {
         double  area();
         double  perimeter();

    }

    class rectangle : Shape
    {
        private int length;
        private int width;

        public rectangle(int l,int w)
        {
            length = l;
            width = w;
        }
        public double area()
        {
            return length * width;
        }
        public double perimeter()
        {
            return 2*(length*width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rec1 = new rectangle(22,5);
            Console.WriteLine(rec1.area());
            Console.WriteLine(rec1.perimeter());
            
        }
    }
}