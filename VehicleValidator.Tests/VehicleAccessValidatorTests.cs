
using System.Net.NetworkInformation;
using VehicleValidator.Models;
using VehicleValidator.Models.Enums;
using VehicleValidator.Services.VehicleAccessValidator;

namespace VehicleValidator.Tests
{
    public class VehicleValidatorTests
    {
        private const string ResultForThirdCategory = "The vehicle can enter both the big ring and the small ring.";
        private const string ResultForSecondCategory = "The vehicle can enter the big ring but not the small ring.";
        private const string ResultForFirstCategory = "The vehicle cannot enter both the big ring and the small ring.";
        private const string ResultForInvalidCategory = "Invalid eco category.";

        private VehicleValidatorAccess _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new VehicleValidatorAccess();

        }

        [Test]
        public void TestValidatorMessageOnThirdEcoCategory()
        {
            Vehicle _vehicle = new Moq.Mock<Vehicle>(1, "TestBrand", "TestModel",
                EcoCategory.CategoryThree, FuelType.Gasoline, 2020).Object;

            string result = _validator.CheckVehicle(_vehicle);
            Assert.That(result, Is.EqualTo(ResultForThirdCategory));
        }
        [Test]
        public void TestValidatorMessageOnSecondEcoCategory()
        {
            Vehicle _vehicle = new Moq.Mock<Vehicle>(1, "TestBrand", "TestModel",
                EcoCategory.CategoryTwo, FuelType.Diesel, 2020).Object;
            string result = _validator.CheckVehicle(_vehicle);
            Assert.That(result, Is.EqualTo(ResultForSecondCategory));
        }
        [Test]
        public void TestValidatorMessageOnFirstEcoCategory()
        {
            Vehicle _vehicle = new Moq.Mock<Vehicle>(1, "TestBrand", "TestModel",
                EcoCategory.CategoryOne, FuelType.Gas, 2020).Object;
            string result = _validator.CheckVehicle(_vehicle);
            Assert.That(result, Is.EqualTo(ResultForFirstCategory));
        }
        [Test]
        public void TestValidatorMessageOnInvalidEcoCategory()
        {
            Vehicle _vehicle = new Moq.Mock<Vehicle>(1, "TestBrand", "TestModel",
                (EcoCategory)999, FuelType.Gas, 2020).Object;
            string result = _validator.CheckVehicle(_vehicle);
            Assert.That(result, Is.EqualTo(ResultForInvalidCategory));
        }
    }
}