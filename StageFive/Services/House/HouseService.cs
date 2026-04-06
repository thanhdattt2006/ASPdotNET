using StageFive.Services.Calc;

namespace StageFive.Services.House;

public class HouseService(ICalcService calcService) : IHouseService
{
    public double Area(double x, double y) => calcService.Multiply(x, y);
    public double Perimeter(double x, double y) => calcService.Sum(x, y) * 2;
}
