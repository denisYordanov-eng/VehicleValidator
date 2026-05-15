using System.ComponentModel.DataAnnotations;
using VehicleValidator.Models.Enums;

namespace VehicleValidator.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }

     
        [Required]
        [Display(Name = "Eco Group")]
        public EcoCategory EcoGroup { get; set; }

        public FuelType Fuel { get; set; }

        [Display(Name = "Year of production")]
        [Required]
        public int YearOfProduction { get; set; }

        public Vehicle() { }
        
        public Vehicle(int id, string brand, string model, EcoCategory ecoGroup, FuelType fuel, int yearOfProduction)
        {
            Id = id;
            Brand = brand;
            Model = model;
            EcoGroup = ecoGroup;
            Fuel = fuel;
            YearOfProduction = yearOfProduction;
        }
    }
}
