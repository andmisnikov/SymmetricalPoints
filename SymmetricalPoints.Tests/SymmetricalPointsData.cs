namespace SymmetricalPoints.Tests
{
    public class SymmetricalPointsData
    {
        public static object[][] SymmetricToHorizontalLine() =>
            new[] {
                new object[] { new Point(-5, -4), new Point(1, 9), new Point(7, -4), new Point(-6, 4), new Point(8, 4), new Point(-5, -4) },
                new object[] { new Point(100, 100) },
                new object[] { new Point(1,1), new Point(1,1), new Point(1,1), new Point(1,1), new Point(1,1) },
                new object[] { new Point(3,1), new Point(1,1), new Point(1,1), new Point(5,1), new Point(1,1) },
                new object[] { new Point(-1, 0), new Point(123123, 0) }
            };


        public static object[][] NotSymmetricToHorizontalLine() =>
            new[] {
                new object[] { new Point(-5, -4), new Point(1, 9), new Point(7, -4), new Point(8, 4), new Point(-5, -4) },
                new object[] { new Point(1, 1), new Point(1, 5) },
            };
    }
}
