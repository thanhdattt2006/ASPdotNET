namespace StageFive.Services;

public class TestService : ITestService
{
    public string GetFullName(string fullname) => $"Hello {fullname}";

    public string GetMessage() => "Hello from TestService!";
}
