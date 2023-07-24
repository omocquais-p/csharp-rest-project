using CustomerProfileAPI.Models;
using Xunit;

namespace csharp_rest_service.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var customerProfile = new CustomerProfile
        {
            Id = "123",
            FirstName = "John",
            LastName = "Smith",
            Email = "test@test.com"
        };
        Assert.Equal("Id: 123 FirstName: John LastName: Smith Email: test@test.com", customerProfile.ToString());
    }
}