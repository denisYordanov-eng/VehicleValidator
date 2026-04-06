
using VehicleValidator.Models;

namespace VehicleValidator.Services.VehicleAccessValidator
{
    public class AmbulanceValidator : IVehicleValidator
    {
        public string CheckVehicle(Vehicle vehicle)
        {
            if (vehicle is Ambulance ambulance)
            {
                if (ambulance.TheLightsAreOn)
                {
                    return "Ambulance is allowed to access both the small and the big ring.";
                }
                else if (!ambulance.TheLightsAreOn && ambulance.EcoGroup < 3)
                {
                    return "Ambulance is not allowed to small and big ring of the city because the lights are off.";
                }
            }
            return "Vehicle is not an ambulance.";
        }
    }
}
