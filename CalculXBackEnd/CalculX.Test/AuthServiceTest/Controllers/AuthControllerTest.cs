using System;
using System.Threading.Tasks;
using AuthService.Entities;
using AuthService.Models;
using CalculX.WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

public class AuthControllerTest
{
    //private readonly Mock<UserManager<ApplicationUser>> _userManagerMock;
    //private readonly Mock<SignInManager<ApplicationUser>> _signInManagerMock;
    //private readonly Mock<IConfiguration> _configurationMock;
    //private readonly AuthController _controller;

    //public AuthControllerTest()
    //{
    //    // Setup mocks for UserManager and SignInManager
    //    _userManagerMock = new Mock<UserManager<ApplicationUser>>(
    //         new Mock<IUserStore<ApplicationUser>>().Object, null, null, null, null, null, null, null, null);

    //    _signInManagerMock = new Mock<SignInManager<ApplicationUser>>(
    //        _userManagerMock.Object,
    //        new Mock<IHttpContextAccessor>().Object,
    //        new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>().Object,
    //        null, null, null, null);

    //    _configurationMock = new Mock<IConfiguration>();
    //    _configurationMock.Setup(config => config["Jwt:Key"]).Returns("wQjEX5n1Jh8Qg6Q+1Xq5/4TQ5xU1Vn9N8Lg/aO/wuRg=");
    //    _configurationMock.Setup(config => config["Jwt:Issuer"]).Returns("https://auth.yourdomain.com");
    //    _configurationMock.Setup(config => config["Jwt:Audience"]).Returns("https://api.yourdomain.com");

    //    // Create the controller instance with mocked dependencies
    //    _controller = new AuthController(_userManagerMock.Object, _signInManagerMock.Object, _configurationMock.Object);
    //}

    //[Fact]
    //public async Task Register_ReturnsOkResult_WhenRegistrationIsSuccessful()
    //{
    //    // Arrange
    //    var model = new RegisterModel
    //    {
    //        Email = "test@example.com",
    //        Password = "Password123!",
    //        FirstName = "John",
    //        LastName = "Doe",
    //        DateofBirth = DateTime.Now.AddYears(-30),
    //        Gender = "Male",
    //        AvatarUrl = "http://example.com/avatar.jpg"
    //    };

    //    _userManagerMock.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), model.Password))
    //                    .ReturnsAsync(IdentityResult.Success);

    //    // Act
    //    var result = await _controller.Register(model);

    //    // Assert
    //    Assert.IsType<Microsoft.AspNetCore.Mvc.OkResult>(result); // Assuming you have a way to return OkResult in your method
    //}

    //[Fact]
    //public async Task Register_ReturnsBadRequest_WhenRegistrationFails()
    //{
    //    // Arrange
    //    var model = new RegisterModel { Email = "test@example.com", Password = "Password123!" };
    //    var errors = new IdentityError[] { new IdentityError { Description = "Error occurred" } };

    //    _userManagerMock.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), model.Password))
    //                    .ReturnsAsync(IdentityResult.Failed(errors));

    //    // Act
    //    var result = await _controller.Register(model);

    //    // Assert
    //    var badRequestResult = Assert.IsType<Microsoft.AspNetCore.Mvc.BadRequestObjectResult>(result); // Adjust according to your actual return type
    //    Assert.Equal(errors, badRequestResult.Value);
    //}

    //[Fact]
    //public async Task Login_ReturnsOkWithToken_WhenLoginIsSuccessful()
    //{
    //    // Arrange
    //    var model = new LoginModel { Username = "test@example.com", Password = "Password123!" };

    //    _signInManagerMock.Setup(x => x.PasswordSignInAsync(model.Username, model.Password, false, false))
    //                      .ReturnsAsync(SignInResult.Success);

    //    var user = new ApplicationUser { UserName = model.Username };

    //    _userManagerMock.Setup(x => x.FindByNameAsync(model.Username))
    //                    .ReturnsAsync(user);

    //    _configurationMock.SetupGet(x => x["Jwt:Key"]).Returns("qWjEX5n1Jh8Qg6Q+1Xq5/4TQ5xU1Vn9N8Lg/aO/wuRg=");
    //    _configurationMock.SetupGet(x => x["Jwt:Issuer"]).Returns("https://localhost:12345");
    //    _configurationMock.SetupGet(x => x["Jwt:Audience"]).Returns("https://localhost:12346");

    //    // Act
    //    var result = await _controller.Login(model);

    //    // Assert
    //    var okResult = Assert.IsType<Microsoft.AspNetCore.Mvc.OkObjectResult>(result); // Adjust according to your actual return type
    //    Assert.NotNull(okResult.Value);
    //}

    //[Fact]
    //public async Task Login_ReturnsUnauthorized_WhenLoginFails()
    //{
    //    // Arrange
    //    var model = new LoginModel { Username = "test@example.com", Password = "WrongPassword!" };

    //    _signInManagerMock.Setup(x => x.PasswordSignInAsync(model.Username, model.Password, false, false))
    //                      .ReturnsAsync(SignInResult.Failed);

    //    // Act
    //    var result = await _controller.Login(model);

    //    // Assert
    //    Assert.IsType<Microsoft.AspNetCore.Mvc.UnauthorizedResult>(result); // Adjust according to your actual return type
    //}
}