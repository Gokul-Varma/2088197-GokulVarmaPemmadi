using NUnit.Framework;
using System.IO;
using System;
using GenericMedicine;

namespace CartonTest
{
    [TestFixture]
    class CartonTests
    {
        Program obj = new Program();

        [TestCase(20, "05/01/2022", "44-20-1, delhi")]
        [TestCase(100, "05/010/2021", "44-89-6, mumbail")]
        public void CartonObjectCreation(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("balu", "dolo65", "carbon iron", DateTime.Parse("12/1/2022"), 2.3);
            Assert.DoesNotThrow(() => obj.CreateCartonDetail(medicineStripCount,launchDate,retailerAddress,med));
        }

        [TestCase(-2, "12/23/2021", "44-20-1, delhi")]
        [TestCase(-100, "12/23/2021", "44-89-6, mumbail")]
        public void LessThanZeroStripCount(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("abhi", "dolo65", "carbon iron", DateTime.Parse("12/12/2022"), 2.3);
   
            var ex = Assert.Throws<Exception>(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
            Assert.That(ex.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }

        [TestCase(2, "12/23/2000", "44-89-6, mumbail")]
        [TestCase(100, "12/23/1900", "44-88-6, delhi")]
        public void LaunchDateCheck(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("ram", "paracetmol", "carbon iron", DateTime.Parse("12/1/2022"), 2.3);

            var ex = Assert.Throws<Exception>(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
            Assert.That(ex.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }

        [TestCase(2, "12/23/2022", "44-89-6, mumbail")]
        [TestCase(100, "12/23/2022", "44-89-6, hyderabad")]
        public void NullCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Assert.AreEqual(obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null),null);
        }
    }
}
