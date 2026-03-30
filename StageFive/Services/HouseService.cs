namespace StageFive.Services;

public class HouseService : IHouseService
{
    public double Area(double length, double width) => CalcService.Multiply(width , length);
    public double Perimeter(double length, double width) => CalcService.Sum(width,length) *  2;
}
