using System.Transactions;
using VehicleValidator.Models.Enums;

namespace VehicleValidator.Models
{
    public class Ambulance : Vehicle
    {
        public bool TheLightsAreOn { get; set; }

        public Ambulance()
        {
           
        }

        public Ambulance(int id, string brand, string model, EcoCategory ecoGroup, FuelType fuelType, int yearOfProduction, bool theLightsAreOn)
            : base(id, brand, model, ecoGroup, fuelType, yearOfProduction)
        {
            TheLightsAreOn = theLightsAreOn;
        }
    }
}
