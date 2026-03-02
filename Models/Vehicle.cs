using System.ComponentModel.DataAnnotations;

namespace VehicleValidator.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }

        [Range(1, 3)]
        [Required]
        public int EcoGroup { get; set; }

        [RegularExpression(@"^(?i)(diesel)|(gasoline)||(gas)|(hybrid)|(electric)$",
            ErrorMessage = "Invalid fuel type!")]
        public string FuelType { get; set; }

        [Required]
        public int YearOfProduction { get; set; }

        public Vehicle() { }
        public Vehicle(int id, string brand, string model, int ecoGroup, string fuelType, int yearOfProduction)
        {
            Id = id;
            Brand = brand;
            Model = model;
            EcoGroup = ecoGroup;
            FuelType = fuelType.ToLower();
            YearOfProduction = yearOfProduction;
        }
    }
}
