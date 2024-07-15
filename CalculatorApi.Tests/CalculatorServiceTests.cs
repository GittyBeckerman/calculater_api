using IO.Swagger.BuisnessLogic;
using Xunit;

public class CalculatorServiceTests
{
    private readonly CalculatorService _calculatorService;

    public CalculatorServiceTests()
    {
        _calculatorService = new CalculatorService();
    }

    [Theory]
    [InlineData(5, 3, "add", 8)]
    [InlineData(5, 3, "subtract", 2)]
    [InlineData(5, 3, "multiply", 15)]
    [InlineData(6, 3, "divide", 2)]
    public void Execute_ValidOperations_ReturnsExpectedResult(int number1, int number2, string operation, int expectedResult)
    {
        // Act
        var result = _calculatorService.Execute(number1, number2, operation);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Execute_DivideByZero_ThrowsDivideByZeroException()
    {
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculatorService.Execute(5, 0, "divide"));
    }

    [Fact]
    public void Execute_InvalidOperation_ThrowsInvalidOperationException()
    {
        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => _calculatorService.Execute(5, 3, "invalid"));
    }
}
