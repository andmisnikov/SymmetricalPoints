namespace SymmetricalPoints.Tests;

public class SymmetricalPointsTests
{
    [Theory]
    [MemberData(nameof(SymmetricalPointsData.SymmetricToHorizontalLine), MemberType = typeof(SymmetricalPointsData))]
    public void IsSymmetric_InputIsSymmetric_ReturnTrue(params Point[] arrPoints)
    {
        var points = new Points(arrPoints);

        bool result = points.IsSymmetricToAnyHorizontalLine();

        Assert.True(result);
    }


    [Theory]
    [MemberData(nameof(SymmetricalPointsData.NotSymmetricToHorizontalLine), MemberType = typeof(SymmetricalPointsData))]
    public void IsSymmetric_InputIsNotSymmetric_ReturnFalse(params Point[] arrPoints)
    {
        var points = new Points(arrPoints);

        bool result = points.IsSymmetricToAnyHorizontalLine();

        Assert.False(result);
    }
}