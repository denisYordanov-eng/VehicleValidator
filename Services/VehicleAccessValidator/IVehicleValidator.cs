using VehicleValidator.Models;

namespace VehicleValidator.Services.VehicleAccessValidator
{
    public interface IVehicleValidator
    {
        string CheckVehicle(Vehicle vehicle);
    }
}
