using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public Shape() { }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Circumference();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(string name, double radius)
            : base(name)
        {
            Radius = radius;
        }
        public override double Area()
        {
            double area = 0;
            area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
        public override double Circumference()
        {
            double circ = 0;
            circ = 2 * Math.PI * Radius;
            return circ;
        }
        public override string ToString()
        {
            return string.Format("{0} Radius={1} Area={2:F2} Circumference={3:F2}", Name, Radius, Area(), Circumference());
        }
    }
    public class Rectangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Rectangle(string name, double side1, double side2)
            : base(name)
        {
            Side1 = side1;
            Side2 = side2;
        }
        public override double Area()
        {
            double area = 0;
            area = Side1 * Side2;
            return area;
        }
        public override double Circumference()
        {
            double circ = 0;
            circ = Side1 * 2 + Side2 * 2;
            return circ;
        }
        public override string ToString()
        {
            return string.Format("{0} Width={1} Height={2} Area={3:F2} Circumference={4:F2}", Name, Side1, Side2, Area(), Circumference());
        }
    }
    public class Shapes
    {
        public List<Shape> shapes { get; set; }
        public Shapes()
        {
            shapes = new List<Shape>();
        }
    }
    public class Tehtava4
    {
        public static void TestTehtava4()
        {
            try
            {
                Shapes shape = new Shapes();
                Circle circle = new Circle("Circle", 1);
                Circle circle1 = new Circle("Circle", 2);
                Rectangle rectangle = new Rectangle("Rectangle", 10, 20);
                Rectangle rectangle1 = new Rectangle("Rectangle", 20, 30);
                shape.shapes.Add(circle);
                shape.shapes.Add(circle1);
                shape.shapes.Add(rectangle);
                shape.shapes.Add(rectangle1);
                foreach (var item in shape.shapes)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}