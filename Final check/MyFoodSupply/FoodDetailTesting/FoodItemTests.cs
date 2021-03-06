using NUnit.Framework;
using System.IO;
using System;
using MyFoodSupply;

namespace FoodDetailTesting
{
    [TestFixture]
    class FoodItemTests
    {
        Program obj = new Program();

        
        [TestCase("hari",2,"14/1/2022", 23.23)]
        [TestCase("chocolate", 2, "14/1/2022", 21000.00)]
        public void FoodItemObjectCreation(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.DoesNotThrow(() => obj.CreateFoodDetail(name,dishType,expiryDate,price));
        }

        
        [TestCase("", 2, "14/1/2022", 23.23)]
        [TestCase("", 2, "14/1/2022", 21000.00)]
        public void EmptyNameException(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Dish name cannot be empty. Please provide valid value"));
        }

        [TestCase("hari", 2, "12*4/1/2022", -0.00001)]
        [TestCase("chocolate", 2, "14/1/2022", -10000)]
        public void NegativePriceExceptionTest(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for dish price. Please provide valid value"));
        }

        [TestCase("hari", 2, "14/1/2022", 200)]
        [TestCase("chocolate", 2, "14/1/2000",22.22)]
        public void ExpiryDateTest(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }

    }
}
