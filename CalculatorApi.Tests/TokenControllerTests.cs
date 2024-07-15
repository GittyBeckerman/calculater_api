using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;
using IO.Swagger.BuisnessLogic;
using IO.Swagger.Controllers;


public class TokenControllerTests
{
    private readonly Mock<IOptions<JwtSettings>> _mockJwtSettings;
    private readonly AuthenticationApiController _controller;
    private readonly JwtSettings _jwtSettings;
    /// <summary>
    /// this test conterollet is test the creation of jwt bearer
    /// </summary>
    public TokenControllerTests()
    {
        _jwtSettings = new JwtSettings
        {
            SecretKey = "your_secret_key_here_your_secret_key_here", 
            ExpirationMinutes = 20
        };
        _mockJwtSettings = new Mock<IOptions<JwtSettings>>();
        _mockJwtSettings.Setup(x => x.Value).Returns(_jwtSettings);
        _controller = new AuthenticationApiController(_mockJwtSettings.Object);
    }

    [Fact]
    public void GetToken_ValidCredentials_ReturnsOkWithToken()
    {
        // Arrange
        var tokenRequest = new IO.Swagger.Models.TokenBody
        {
            Username = "gitty",
            Password = "12345678"
        };

        // Act
        var result = _controller.GetToken(tokenRequest);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var tokenResponse = okResult.Value as dynamic;
        Assert.NotNull(tokenResponse);
    }

    [Fact]
   
    public void GetToken_InvalidCredentials_ReturnsBadRequest()
    {
        // Arrange
        var tokenRequest = new IO.Swagger.Models.TokenBody
        {
            Username = "",
            Password = "invalidPassword"
        };

        // Act
        var result = _controller.GetToken(tokenRequest);

        // Assert
        Assert.IsType<BadRequestObjectResult>(result);
    }
}
