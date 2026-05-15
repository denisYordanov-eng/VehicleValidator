using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleValidator.Models;
using VehicleValidator.Models.Enums;

namespace VehicleValidator.Tests
{
    public class VehicleTests
    {
        [Test]
        public void CreateVehicleTest()
        {
            Vehicle vehicle = new Vehicle(1, "TestBrand", "TestModel"
                , EcoCategory.CategoryTwo, FuelType.Diesel, 2004);

            Assert.That(vehicle.Id, Is.EqualTo(1));
            Assert.That(vehicle.Brand, Is.EqualTo("TestBrand"));
            Assert.That(vehicle.Model, Is.EqualTo("TestModel"));
            Assert.That(vehicle.EcoGroup, Is.EqualTo(EcoCategory.CategoryTwo));
            Assert.That(vehicle.Fuel, Is.EqualTo(FuelType.Diesel));
            Assert.That(vehicle.YearOfProduction, Is.EqualTo(2004));
            
        }
    }
}
