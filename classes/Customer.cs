using System.Diagnostics.Contracts;
using System.Dynamic;

namespace CustomerClass;

public class Customer 
{
    public int CustomerId {get; set;}
    public string CustomerName {get; set;}
    public int Deposit {get; set;}
    public bool InsurancePaid {get; set;}
    public int Age {get; set;}
    public bool DrivingLicence {get; set;}

    public static int numberOfCustomers;

   public Customer(int CustomerId, string CustomerName, int Deposit, bool InsurancePaid, int Age, bool DrivingLicence)
    {
        this.CustomerId = CustomerId;
        this.CustomerName = CustomerName;
        this.Deposit = Deposit;
        this.InsurancePaid = InsurancePaid;
        this.Age = Age;
        this.DrivingLicence = DrivingLicence;

        numberOfCustomers ++;
    }
}