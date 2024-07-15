using IO.Swagger.BuisnessLogic;
using IO.Swagger.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace YourNamespace.Tests
{
    public class CalculatorApiControllerTests
    {
        private readonly CalculatorApiController _controller;

        public CalculatorApiControllerTests()
        {
            var calculatorService = new CalculatorService(); // Instantiate the service directly
            _controller = new CalculatorApiController(calculatorService);
        }

        [Fact]
        public void AddOperation_ValidInputs_ReturnsOk()
        {
            // Arrange
            int number1 = 5;
            int number2 = 3;
            int expectedResult = 8;

            // Act
            var result = _controller.AddOperation(number1, number2);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var resultValue = Assert.IsType<int>(okResult.Value.GetType().GetProperty("result").GetValue(okResult.Value, null));
            Assert.Equal(expectedResult, resultValue);
        }

        [Fact]
        public void SubtractOperation_ValidInputs_ReturnsOk()
        {
            // Arrange
            int number1 = 5;
            int number2 = 3;
            int expectedResult = 2;

            // Act
            var result = _controller.SubtractOperation(number1, number2);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var resultValue = Assert.IsType<int>(okResult.Value.GetType().GetProperty("result").GetValue(okResult.Value, null));
            Assert.Equal(expectedResult, resultValue);
        }

        [Fact]
        public void MultiplyOperation_ValidInputs_ReturnsOk()
        {
            // Arrange
            int number1 = 5;
            int number2 = 3;
            int expectedResult = 15;

            // Act
            var result = _controller.MultiplyOperation(number1, number2);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var resultValue = Assert.IsType<int>(okResult.Value.GetType().GetProperty("result").GetValue(okResult.Value, null));
            Assert.Equal(expectedResult, resultValue);
        }

        [Fact]
        public void DivideOperation_ValidInputs_ReturnsOk()
        {
            // Arrange
            int number1 = 6;
            int number2 = 3;
            int expectedResult = 2;

            // Act
            var result = _controller.DivideOperation(number1, number2);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var resultValue = Assert.IsType<int>(okResult.Value.GetType().GetProperty("result").GetValue(okResult.Value, null));
            Assert.Equal(expectedResult, resultValue);
        }

        [Fact]
        public void DivideOperation_DivideByZero_ReturnsBadRequest()
        {
            // Arrange
            int number1 = 5;
            int number2 = 0;

            // Act
            var result = _controller.DivideOperation(number1, number2);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Cannot divide by zero", badRequestResult.Value);
        }
    }
}
