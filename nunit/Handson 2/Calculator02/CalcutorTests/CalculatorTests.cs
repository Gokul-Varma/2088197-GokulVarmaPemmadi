using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator02;
using System.Collections;


namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        CalculatorApp calculator;
        [SetUp]
        public void Initialize()
        {
            calculator = new CalculatorApp();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [Test]
        public void AddTest()
        {
            //Arrange
            //Calculator calculator = new Calculator();
            int input1 = 20;
            int input2 = 20;
            int expected = 40;

            //Act
            int actual = calculator.Add(input1, input2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractTest()
        {
            //Arrange
            //Calculator calc = new Calculator();
            int input1 = 40;
            int input2 = 20;
            int expected = 20;

            //Act
            int actual = calculator.Substract(input1, input2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Ignore("Divide not yet implemented")]
        public void DivideTest()
        {

        }
        [Test]
        [TestCase(6, 3, 9)]
        [TestCase(8, 4, 12)]
        [TestCase(10, 5, 15)]
        public void AddTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Add(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource("AddTestData")]
        public void AddTest2(int input1, int input2, int expected)
        {
            int actual = calculator.Add(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        public static object[] AddTestData =
       {
            new object[] { 11, 22, 33 },
            new object[] { 10, 20, 30 },
            new object[] { 15, 3, 18 }
};
        [Test]
        [TestCase(3, 2, 1)]
        [TestCase(8, 2, 6)]
        [TestCase(9, 3, 6)]
        public void SubTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Substract(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        public void MultiplyTest()
        {
            int input1 = 20;
            int input2 = 10;
            int expected = 200;
            int actual = calculator.Multiply(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(4, 2, 8)]
        [TestCase(10, 2, 20)]
        [TestCase(2, 3, 6)]
        public void MultiplyTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Multiply(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        public void DivisionTest()
        {
            int input1 = 10;
            int input2 = 10;
            int expected = 1;
            int actual = calculator.Division(input1, input2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(8, 4, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(15, 3, 5)]
        public void DivisionTest1(int input1, int input2, int expected)
        {
            int actual = calculator.Division(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(2.0,2.0,1.0)]
        public void DivisionTest(double input1, double input2, double expected)
        {
            try
            {
                double result = calculator.Division(input1, input2);
                Assert.AreEqual(expected, result);
            }
            catch
            {
                Assert.Fail("Division by zero");




            }
        }
        [Test]
        [TestCase(99,11,9)]
        public void Division1Test(double input1,double input2,double expected)
        {
            try
            {
                double result = calculator.Division(input1, input2);
                Assert.AreEqual(expected, result);
            }
            catch(ArgumentException exp)
            {
                Assert.Fail("Division by zero");




            }

        }

        [Test]
        public void TestAddandClear()
        {
            double res = calculator.Add(16, 29);

            Assert.AreEqual(45, res);

           calculator.AllClear();
           res = calculator.GetResult;
            Assert.AreEqual(0, res);

        }

    }
}