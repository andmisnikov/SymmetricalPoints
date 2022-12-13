using System;

namespace SymmetricalPoints
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //(-5; -4), (1; 9), (7; -4), (-6; 4), (8; 4), (-5; -4).
            Point[] arrPoints = new Point[6]
            {
                new Point(-5, -4), new Point(1, 9), new Point(7, -4), new Point (-6, 4), new Point (8,4), new Point(-5, -4)
            };

            Points points = new Points(arrPoints);
            Console.WriteLine($"Symetric? {points.IsSymmetricToAnyHorizontalLine()}");
        }
    }
}
