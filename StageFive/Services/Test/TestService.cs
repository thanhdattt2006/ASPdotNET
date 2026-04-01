namespace StageFive.Services.Test;

public class TestService : ITestService
{
    public string GetFullName(string fullname) => $"Hello {fullname}";

    public string GetMessage() => "Hello from TestService!";
}
