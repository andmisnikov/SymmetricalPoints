using System;
using System.Linq;

namespace SymmetricalPoints
{
    public class Points
    {
        Point[] _points;

        public Points(Point[] points)
        {
            _points = points;
        }

        public Point[] SortPointsByX(Point[] points)
        {
            return points.OrderBy(p => p.X).ToArray();
        }

        public Point[] GetDistictPoints(Point[] points)
        {
            return points.Distinct().ToArray();
        }

        public bool IsSymmetricToAnyHorizontalLine()
        {
            if (_points == null)
            {
                return true;
            }

            var distinctPoints = GetDistictPoints(_points);
            var distinctSortedPointsByX = SortPointsByX(distinctPoints);
            

            if (distinctSortedPointsByX.Length <= 1)
            {
                return true;
            }

            double possibleXSymmetricLine;
            int lefSideIndex;
            int rightSideIndex;

            if (distinctSortedPointsByX.Length % 2 == 0)
            {
                lefSideIndex = distinctSortedPointsByX.Length / 2 - 1;
                rightSideIndex = distinctSortedPointsByX.Length / 2;

                possibleXSymmetricLine = (distinctSortedPointsByX[lefSideIndex].X + distinctSortedPointsByX[rightSideIndex].X) / 2;
            }
            else
            {
                lefSideIndex = distinctSortedPointsByX.Length / 2 - 1;
                rightSideIndex = distinctSortedPointsByX.Length / 2 + 1;
                possibleXSymmetricLine = distinctSortedPointsByX[distinctSortedPointsByX.Length / 2].X;
            }

            for (int i = 0; i < distinctSortedPointsByX.Length / 2; i++)
            {
                if (Diff(distinctSortedPointsByX[lefSideIndex].Y, possibleXSymmetricLine) != Diff(distinctSortedPointsByX[rightSideIndex].Y, possibleXSymmetricLine))
                {
                    return false;
                }

                lefSideIndex--;
                rightSideIndex++;
            }

            return true;
        }

        private double Diff(double x1, double x2)
        {
            return Math.Abs(x1 - x2);
        }
    }
}
