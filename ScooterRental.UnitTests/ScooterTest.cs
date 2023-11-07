using Xunit;
using ScooterClasses;
using System.Configuration.Assemblies;


namespace ScooterRental.UnitTests;




public class ScooterTest
{


    [Fact]

    public void testFullClass()
    {
        var test = new Scooter(87, 23000, 40, "Vespa", "No Damage", true, true );

        Assert.Equal(87, test.id);
        Assert.Equal(23000, test.mileage);
        Assert.Equal(40, test.costPerDay);
        Assert.Equal("Vespa", test.scooterModel);
        Assert.Equal("No Damage", test.preExistingDamage);
        Assert.True(test.rentersInsurance);
        Assert.True(test.Available);
    }
    // [Fact]
    // public void testIsUpper()
    // {
    //     //arrange 
    //     bool expected = true;

    //     //act 
    //     bool actual = Class1.StartsWithUpper("A");

    //     //assert 
    //     Assert.Equal(expected, actual);

    // }
    // [Theory]
    // [InlineData("Sam")]
    // [InlineData("Ted")]
    // public void testMultipleParams(string test);
    // {
    //     //arrange 
    //     bool expected = true;

    //     //act 

    //     bool actual = Class1.StartsWithUpper(test);

    // }

}