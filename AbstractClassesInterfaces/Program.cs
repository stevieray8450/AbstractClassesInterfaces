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

        //public List<double> SideLengths
        //{
        //    get { return sideLengths; }
        //    set { sideLengths.Add = value; }
        //}

        public List<double> SideLengths = new List<double>();


        public void CalcPerimeter()
        {
            foreach (double length in this.SideLengths)
            {
                Perimeter += length;
            }
        }

        public void CalcArea()
        {
            if (NumOfSides == 3)
            {
                // assumes sideLengths[0] is "base"
                Area = .5 * (SideLengths[0] * SideLengths[1]);
            }
            else if (NumOfSides == 4)
            {
                // assumes sideLengths[0] is rectangle length and sideLengths[1] is rectangle width
                Area = (SideLengths[0] * SideLengths[1]);
            }
            else
            {
                Console.WriteLine("At this time, polygons with more than 4 sides are not supported.");
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
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("R1's number of sides: " + r1.NumOfSides);
            r1.SideLengths.Add(4);
            r1.SideLengths.Add(5);
            r1.SideLengths.Add(4);
            r1.SideLengths.Add(5);
            r1.CalcArea();
            Console.WriteLine("R1's area: " + r1.Area);
        }
    }
}
