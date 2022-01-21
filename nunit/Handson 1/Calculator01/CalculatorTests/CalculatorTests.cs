using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator01;
using System.Collections;


namespace Calc
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
            
            int input1 = 20;
            int input2 = 20;
            int expected = 40;

           
            int actual = calculator.Add(input1, input2);

            Assert.AreEqual(expected, actual);
        }

       
     

        
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(10, 2, 12)]
        [TestCase(20, 13, 33)]
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
        new object[] { 4, 5, 9 },
        new object[] { 10, 20, 30 },
        new object[] { 5, 5, 10 }
        };
      

    }
}