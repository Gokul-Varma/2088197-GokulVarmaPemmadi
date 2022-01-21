using System;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;

namespace PlayerManger.Tests
{
    //[TestClass]
    [TestFixture]
    public class Tests
    {//
        Player p1, p2;
        [OneTimeSetUp]
        public void Init()
        {
            p1 = new Player("Albert", 23, "India", 30);
        }


        [TestCase("Albert", true)]
        [TestCase("Albert", false)]
        [TestCase("", true)]

        // [TestMethod]
        public void RegisterNewPlayer_GetsString_ReturnsPlayer(string name, bool value)
        {
            Mock<IPlayerMapper> mockObj = new Mock<IPlayerMapper>();
            mockObj.Setup(meth => meth.IsPlayerNameExistsInDb(name)).Returns(value);
            mockObj.Setup(meth => meth.AddNewPlayerIntoDb(name));
            try
            {
                p2 = Player.RegisterNewPlayer(name, mockObj.Object);
                Assert.AreEqual(p2.Name, name);
                Assert.AreEqual(p2.Age, p1.Age);
                Assert.AreEqual(p2.Country, p1.Country);
                Assert.AreEqual(p2.NoOfMatches, p1.NoOfMatches);

            }
            catch (ArgumentException e)
            {
                Assert.IsTrue(e is ArgumentException);
            }
        }
    }
}
/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayerManager;
namespace PlayerManagerTests
{
[TestFixture]
public class PlayerMapperTest
{
[Test]
public void EmptyTest()
{
var moq = new Mock<IPlayerMapper>();
Player player = Player.RegisterNewPlayer("PlayerMapperTest", moq.Object);
}
[Test]
public void AlreadyExistsTest()
{
var moq=new Mock<IPlayerMapper>();
moq.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
Player player = Player.RegisterNewPlayer("Test", moq.Object);
Assert.AreEqual("Test", player.Name);
Assert.AreEqual(23, player.Age);
Assert.AreEqual(30, player.NoOfMatches);
}
}
}
 */