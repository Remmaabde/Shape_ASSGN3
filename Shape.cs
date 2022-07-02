using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Shape_Assignment
{
    abstract class Shape
    {
        public abstract double calc_area();
        public abstract double calc_perimeter();
    }

    class circle : Shape
    {

        public double circumfernce;
        public double area;

        static readonly double PI = 3.14;
        public int radius { get; set; }




        public override double calc_area()
        {
            return (PI * radius * radius);
        }

        public override double calc_perimeter()
        {
            return (2 * PI * radius);
        }
        class rectangle : Shape
        {
            public int length { get; set; }
            public int width { get; set; }

            

            public override double calc_area()
            {
                return (length * width);
            }

            public override double calc_perimeter()
            {
                return (2*length + 2*width);
            }
        }
        class program
        {
            static void Main (String[] args)
            {
                circle circle1 = new circle();
                WriteLine("plesae enter radius: >>");
                circle1.radius = int.Parse(ReadLine());
                WriteLine("Area of the circle is : ");
                WriteLine(circle1.calc_area());
                circle circle2 = new circle();
                WriteLine("Please enter radius: >>");
                circle2.radius= int.Parse(ReadLine());
                WriteLine("The circumference of the circle is: >>");
                WriteLine(circle1.calc_perimeter());


                rectangle rectangle1 = new rectangle();
                WriteLine("Please enter length: >>");
                rectangle1.length = int.Parse(ReadLine());
                WriteLine("Please enter width : >>");
                rectangle1.width = int.Parse(ReadLine());
                WriteLine("The perimeter of the rectangle is: >>");
                WriteLine(rectangle1.calc_perimeter());

                rectangle rectangle2 = new rectangle();
                WriteLine("Please enter length: >>");
                rectangle2.length = int.Parse(ReadLine());
                WriteLine("Please enter width: >>");
                rectangle2.width = int.Parse(ReadLine());
                WriteLine("The area of rectangle is : >>");
                WriteLine(rectangle2.calc_area());

            }
        }
    }
}
      

