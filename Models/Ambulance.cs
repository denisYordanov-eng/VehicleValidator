using System.Transactions;

namespace VehicleValidator.Models
{
    public class Ambulance : Vehicle
    {
        public bool TheLightsAreOn { get; set; }

        public Ambulance()
        {
           
        }

        public Ambulance(int id, string brand, string model, int ecoGroup, string fuelType, int yearOfProduction, bool theLightsAreOn)
            : base(id, brand, model, ecoGroup, fuelType, yearOfProduction)
        {
            TheLightsAreOn = theLightsAreOn;
        }
    }
}
