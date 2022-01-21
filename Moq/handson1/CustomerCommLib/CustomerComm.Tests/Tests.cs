using CustomerCommLib;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test1()
        {
            Mock<IMailSender> mockObj = new Mock<IMailSender>();
            mockObj.Setup(m => m.SendMail("cust123@abc.com", "Some Message")).Returns(true);
            CustomerCommLib.CustomerComm cc = new CustomerCommLib.CustomerComm(mockObj.Object);
            bool result = cc.SendMailToCustomer();

            Assert.AreEqual(true, result);
        }
    }
}