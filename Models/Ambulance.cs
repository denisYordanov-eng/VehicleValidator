using System.Transactions;
using VehicleValidator.Models.Enums;

namespace VehicleValidator.Models
{
    public class Ambulance : Vehicle
    {
        public bool TheLightsAreOn { get; set; }
        public Ambulance() { }
       
        public Ambulance(int id, string brand, string model, EcoCategory ecoGroup, FuelType fuel, int yearOfProduction, bool theLightsAreOn)
            : base(id, brand, model, ecoGroup, fuel, yearOfProduction)
        {
            TheLightsAreOn = theLightsAreOn;
        }
    }
}
