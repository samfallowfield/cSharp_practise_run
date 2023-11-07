
using CustomerClass;
using ScooterClasses;

namespace RentalClass;

public class RentalTransaction
{
    private Customer customer;
    private Scooter scooter;
    private DateTime rentalStartDate;
    private DateTime rentalEndDate;

    public RentalTransaction(Customer customer, Scooter scooter, DateTime rentalStartDate, DateTime rentalEndDate)
    {
        this.customer = customer;
        this.scooter = scooter;
        this.rentalStartDate = rentalStartDate;
        this.rentalEndDate = rentalEndDate;
    }

    public double CalculateRentalCost()
    {
        int rentalDays = (rentalEndDate - rentalStartDate).Days;
        double rentalCost = rentalDays * scooter.costPerDay;

        if (!customer.InsurancePaid && scooter.rentersInsurance)
        {
            rentalCost += scooter.costPerDay * 0.1; // 10% additional cost for renters insurance if customer insurance is not paid
        }

        return rentalCost;
    }

    public Customer GetCustomer()
    {
        return customer;
    }

    public Scooter GetScooter()
    {
        return scooter;
    }

    public DateTime GetRentalStartDate()
    {
        return rentalStartDate;
    }

    public DateTime GetRentalEndDate()
    {
        return rentalEndDate;
    }
}





