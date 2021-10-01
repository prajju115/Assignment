using System;

namespace Assignment
{
    class CircleDemo
    {
        double radius;
        const double PI = 3.142;
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public double CalcDiameter()
        {
            return 2 * radius;
        }
        public double CalcArea()
        {
            return PI * radius * radius;
        }
    }
    class Circle
    {
        static void Main(string[] args)
        {
            CircleDemo c1 = new CircleDemo();
            c1.SetRadius(2);
            Console.WriteLine(c1.GetRadius());
            Console.WriteLine(c1.CalcDiameter());
            Console.WriteLine(c1.CalcArea());

        }
    }
}