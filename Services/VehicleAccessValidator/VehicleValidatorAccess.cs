using VehicleValidator.Models;

namespace VehicleValidator.Services.VehicleAccessValidator
{
    public class VehicleValidatorAccess : IVehicleValidator
    {
      
        public string CheckVehicle(Vehicle vehicle)
        {
            
            switch (vehicle.EcoGroup)
            {
                case Models.Enums.EcoCategory.CategoryOne:
                    return "The vehicle cannot enter both the big ring and the small ring.";
                case Models.Enums.EcoCategory.CategoryTwo:
                    return "The vehicle can enter the big ring but not the small ring.";
                case Models.Enums.EcoCategory.CategoryThree:
                    return "The vehicle can enter both the big ring and the small ring.";
                default:
                    return "Invalid eco category.";
            }
        }
    }
}
