using VehicleAccesValidator.Services;
using VehicleValidator.Models;

namespace VehicleValidator.Services.VehicleAccesValidator
{
        public class VehicleValidatorAccess : BaseVehiclesValidator
        {
            public VehicleValidatorAccess() { }
            public override string CheckVehicle(Vehicle vehicle)
            {
                switch (vehicle.EcoGroup)
                {
                    case 1:
                        return "The vehicle cannot enter both the big ring and the small ring.";
                    case 2:
                        return "The vehicle can enter the big ring but not the small ring.";
                    default:
                        return "The vehicle can enter both the big ring and the small ring.";
                }
            }
        }
}
