namespace StageFive.Services.Calc;

public class CalcService : ICalcService
{
    public double Multiply(double a, double b) => a * b;
    public double Sum(double a, double b) => a + b;
}
