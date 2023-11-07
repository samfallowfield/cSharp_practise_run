using Xunit;
using CustomerClass;
using System.Configuration.Assemblies;


namespace ScooterRental.UnitTests;

public class CustomerTests
{

    [Fact]

    public void testCustomerClass()

    {

        var test = new Customer(1, "Joe", 200, true, 44, true);

        Assert.Equal(1, test.CustomerId);
        Assert.Equal("Joe", test.CustomerName);
        Assert.Equal(200, test.Deposit);
        Assert.True(test.InsurancePaid);
        Assert.Equal(44, test.Age);
        Assert.True(test.DrivingLicence);



    }

}
