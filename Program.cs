using System;

namespace Circle_Program
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());

           area = Math.PI * radius *radius; 

            Console.WriteLine("Area{0} is {1}",radius,area);
            
        }
    }
}
