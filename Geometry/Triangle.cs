using System;

namespace Geometry
{
    public class Triangle
    {
        public static double Area(double triangleBase, double height) => triangleBase * height / 2.0;

        public static double Hypoteneuse(double SideA, double SideB) => Math.Sqrt(SideA * SideA + SideB * SideB);
    }
}
