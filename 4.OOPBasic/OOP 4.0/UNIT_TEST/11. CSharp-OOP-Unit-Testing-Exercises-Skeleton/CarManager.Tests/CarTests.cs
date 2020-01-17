using CarManager;
using NUnit.Framework;

namespace Tests
{

    public class CarTests
    {

        private Car newCar;

        [SetUp]
        public void Setup()
        {
            var make = "stuf";
            var model = "stuf";
            var fuelConsumption = 23.231;
            var fuelCapacity = 99.99;

            newCar = new Car(make,model,fuelConsumption,fuelCapacity);
        }

        [Test]
        public void ConstructorTest()
        {
            var testCar = new Car("somewhere", "model", 12.3, 33.3);
            Assert.That(testCar.GetType().Name.ToString(), Is.EqualTo("Car"),
                testCar.Make, Is.EqualTo("somewhere"),
                testCar.Model, Is.EqualTo("model"),
                testCar.FuelConsumption,Is.EqualTo(12.3),
                testCar.FuelCapacity,Is.EqualTo(33.3));
        }

        [Test]
        public void EmptyMake()
        {
       
            Assert.That(() => new Car(string.Empty, "model", 12.3, 33.3),
                Throws.ArgumentException.With.Message.EqualTo("Make cannot be null or empty!"));
        }

        [Test]
        public void NullMake()
        {

            Assert.That(() => new Car(null, "model", 12.3, 33.3),
                Throws.ArgumentException.With.Message.EqualTo("Make cannot be null or empty!"));
        }


        [Test]
        public void EmptyModel()
        {

            Assert.That(() => new Car("make", string.Empty, 12.3, 33.3),
                Throws.ArgumentException.With.Message.EqualTo("Model cannot be null or empty!"));
        }

        [Test]
        public void NullModel()
        {

            Assert.That(() => new Car("make",null,  12.3, 33.3),
                Throws.ArgumentException.With.Message.EqualTo("Model cannot be null or empty!"));
        }

        [Test]
        public void NegativeFuelConsumptionl()
        {

            Assert.That(() => new Car("make", "modle", -12.3, 33.3),
                Throws.ArgumentException.With.Message.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

        [Test]
        public void ZeroFuelConsumption()
        {

            Assert.That(() => new Car("make", "modle", 0, 33.3),
                 Throws.ArgumentException.With.Message.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

        [Test]
        public void NegativeFuelCapacity()
        {

            Assert.That(() => new Car("make", "modle", 12.3, 0),
                Throws.ArgumentException.With.Message.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

        [Test]
        public void NonZeroRefuelQuantity()
        {
            
              Assert.That(()=>newCar.Refuel(0),Throws.ArgumentException.With.Message.EqualTo("Fuel amount cannot be zero or negative!"));
        
        }

        [Test]
        public void NonNegativrRefuelQuantity()
        {

            Assert.That(() => newCar.Refuel(-14), Throws.ArgumentException.With.Message.EqualTo("Fuel amount cannot be zero or negative!"));

        }

        [Test]
        public void OverTheCapacityRefuelQuantity()
        {
            newCar.Refuel(999);
            Assert.That(newCar.FuelAmount, Is.EqualTo(newCar.FuelCapacity));

        }

        [Test]
        public void EnoughFuelToDrive()
        {
           
            Assert.That(() => newCar.Drive(123124),
                Throws.InvalidOperationException
                .With.Message.EqualTo("You don't have enough fuel to drive!"));

        }

        [Test]
        public void EnoughFuel()
        {

            Assert.That(() => newCar.Drive(123124),
                Throws.InvalidOperationException
                .With.Message.EqualTo("You don't have enough fuel to drive!"));

        }

    }
}