﻿using NUnit.Framework;
using System.IO;
using System;
using GenericMedicine;

namespace MedicineTestProject
{
    [TestFixture]
    public class MedicineTests
    {
        Program obj = new Program();

        [SetUp]
        public void Setup()
        {

        }

        [TestCase("Ram","paracetmol", "potassium sorbate", "14/1/2023",200)]
        [TestCase("Laxman", "Dolo65", " iron", "05/10/2023", 23)]
        public void MedicineObjectCreation(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.DoesNotThrow(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [TestCase("", "paracetmol", "potassium sorbate", "14/1/2023", 200)]
        [TestCase("", "Dolo65", "iron", "05/10/2023", 24)]
        public void EmptyNameException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Medicine name cannot be empty. Please provide valid value"));
        }

        [TestCase("Ram", "Paracetmol", "potassium sorbate", "05/10/2023", -2.3)]
        [TestCase("Laxman", "dolo65", "iron", "02/10/2023", -24)]
        public void LessThanZeroPriceException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }

        [TestCase("RAm", "pracetmol", "potassium sorbate", "02/10/2020", 230.0)]
        [TestCase("Laxman","Dolo65", "Iron", "02/12/1900", 24)]
        public void ExpriyDateCheck(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }


    }

}