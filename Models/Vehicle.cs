using System.ComponentModel.DataAnnotations;

namespace VehicleValidator.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        [Range(1, 3)]
        public int EcoGroup { get; set; }

        [RegularExpression(@"^(?i)(diesel)|(gasoline)||(gas)|(hybrid)|(electric)$")]
        public string FuelType { get; set; }

        [Required]
        public int YearOfProduction { get; set; }

        public Vehicle() { }
        public Vehicle(int id, string brand, string model, int ecogroup, string fueltype, int yearOfProduction)
        {
            Id = id;
            Brand = brand;
            Model = model;
            EcoGroup = ecogroup;
            FuelType = fueltype;
            YearOfProduction = yearOfProduction;
        }
    }
}
