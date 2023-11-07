using System.Dynamic;

namespace ScooterClasses;

public class Scooter
{
    public int id {get; set;}

    public int mileage {get; set;}

    public int costPerDay {get; set;}

    public string scooterModel {get; set;}

    public string preExistingDamage {get; set;}

    public bool rentersInsurance {get; set;}

    public bool Available {get; set;}

    public static int numberOfScooters;






    public Scooter(int id, int mileage, int costPerDay, string scooterModel, string preExistingDamage, bool rentersInsurance, bool Available)
    {
        this.id = id;
        this.mileage = mileage;
        this.costPerDay = costPerDay;
        this.scooterModel = scooterModel;
        this.preExistingDamage = preExistingDamage;
        this.rentersInsurance = rentersInsurance;
        this.Available = Available;

        numberOfScooters ++;
    }
}
