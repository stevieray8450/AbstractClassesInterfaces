using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesInterfaces
{
    public abstract class Polygon : ICalc
    {
        private double numOfSides;
        // private List<double> sideLengths = new List<double>();
        private double perimeter;
        private double area;
        public List<double> SideLengths = new List<double>();

        public double NumOfSides
        {
            get { return numOfSides; }
            set { this.numOfSides = value; }
        }

        public double Perimeter
        {
            get { return perimeter; }
            set { this.perimeter = value; }
        }

        public double Area
        {
            get { return area; }
            set { this.area = value; }
        }

        public void CalcPerimeter()
        {
            foreach (double length in this.SideLengths)
            {
                Perimeter += length;
            }
        }

        public void CalcArea()
        {
            // assumes sideLengths[0] is rectangle length and sideLengths[1] is rectangle width
            if (this.NumOfSides == 4)
            {
                Area = (SideLengths[0] * SideLengths[1]);
            }
            // assumes sideLengths[0] is triangle base and sideLengths[1] is triangle height
            else if (this.NumOfSides == 3)
            {
                Area = .5 * (SideLengths[0] * SideLengths[1]);
            }
        }
    }

        public interface ICalc
        {
            void CalcPerimeter();
            void CalcArea();
        }

    class Rectangle : Polygon
    {
        public Rectangle()
        {
            this.NumOfSides = 4;
        }
    }

    class Triangle : Polygon
    {
        public Triangle()
        {
            this.NumOfSides = 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("R1's number of sides: {0}", r1.NumOfSides);
            r1.SideLengths.Add(4);
            r1.SideLengths.Add(5);
            r1.SideLengths.Add(4);
            r1.SideLengths.Add(5);
            r1.CalcArea();
            Console.WriteLine("R1's area: {0}", r1.Area);
            r1.CalcPerimeter();
            Console.WriteLine("R1's perimeter: {0}", r1.Perimeter);

            Console.WriteLine();
            Console.WriteLine();

            Triangle t1 = new Triangle();
            Console.WriteLine("T1's number of sides: {0}", t1.NumOfSides);
            t1.SideLengths.Add(3);
            t1.SideLengths.Add(2);
            t1.SideLengths.Add(1);
            Console.WriteLine("T1's area: {0}", t1.Area);
            t1.CalcPerimeter();
            Console.WriteLine("T1's perimeter: {0}", t1.Perimeter);
        }
    }
}
