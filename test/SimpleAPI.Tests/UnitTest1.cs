using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void GetReturnsCorrectNumber()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Les Jackson", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }


}