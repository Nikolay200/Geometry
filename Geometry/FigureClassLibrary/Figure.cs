using System;
using System.Collections.Generic;

namespace FigureClassLibrary
{

    public class Figure
    {
        public static double Pi = 3.14;
        public string name;
        private double side1;
        private double side2;
        private double side3;

        public Figure(string name, double side1)
        {
            this.name = name;
            this.side1 = side1;
        }

        public Figure(string name, double side1, double side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }

        public Figure(string name, double side1, double side2, double side3)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }      

        
        public double CalculateSquare(double side1)
        {
            return Pi * side1 * side1;
        }

        public double CalculatePerimeter(double side1)
        {
            return 2 * Pi * side1;
        }

        public double CalculateSquare(double side1, double side2)
        {
            return side1 * side2;
        }

        public double CalculatePerimeter(double side1, double side2)
        {
            return (side1 + side2) * 2;
        }

        public double CalculateSquare(double side1, double side2, double side3)
        {
            var halfPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        }

        public double CalculatePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        public bool IsPerpendicular(double side1, double side2, double side3)
        {
            if ((side1 * side1 + side2 * side2 == side3 * side3) || (side1 * side1 + side3 * side3 == side2 * side2) || (side3 * side3 + side2 * side2 == side1 * side1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}