using NUnit.Framework;
using System.IO;
using System;
using MyFoodSupply;

namespace SupplyDetailsTesting
{
    class SupplyDetailsTests
    {
        Program obj = new Program();


        [TestCase(2, "14/1/2022", "Ram",23.22)]
        [TestCase(10, "14/1/2022", "Laxman",45)]
        public void CartonObjectCreation(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = obj.CreateFoodDetail("chocolate", 2, DateTime.Parse("14/1/2022"), 21000.00);
            Assert.DoesNotThrow(() => obj.CreateSupplyDetail(foodItemCount,requestDate,sellerName,packingCharge,food));
            
        }

        [TestCase(-2, "14/1/2022", "Ram", 23.22)]
        [TestCase(-10, "14/1/2022", "Laxman", 45)]
        public void LessThanZeroFoodItemCount(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = obj.CreateFoodDetail("chocolate", 2, DateTime.Parse("14/12/2022"), 21000.00);

            var ex = Assert.Throws<Exception>(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.That(ex.Message, Is.EqualTo("Incorrect food item count. Please check"));
        }

        [TestCase(2, "14/1/2023", "Ram", 23.22)]
        [TestCase(10, "14/1/2023", "Laxman", 45)]
        public void RequestDateValidity(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = obj.CreateFoodDetail("chocolate", 2, DateTime.Parse("14/1/2022"), 21000.00);

            var ex = Assert.Throws<Exception>(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.That(ex.Message, Is.EqualTo("Request date greater than expiry date. Please check"));
        }

        [TestCase(2, "14/1/2022", "Ram", 23.22)]
        [TestCase(10, "14/1/2022", "Laxman", 45)]
        public void NullSupplyObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            Assert.AreEqual(obj.CreateSupplyDetail(foodItemCount,requestDate,sellerName,packingCharge,null), null);
        }


    }
}
