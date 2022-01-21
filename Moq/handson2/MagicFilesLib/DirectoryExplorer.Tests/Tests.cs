using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        private readonly ICollection<string> files = new List<string>();
        Mock<IDirectoryExplorer> mockObj;

        [OneTimeSetUp]
        public void init()
        {
            files.Add(_file1);
            files.Add(_file2);
            mockObj = new Mock<IDirectoryExplorer>();
            mockObj.Setup(m => m.GetFiles(@"C:\")).Returns(files);

        }
        [Test]
        public void Test_Contains_file1()
        {
            Assert.That(mockObj.Object.GetFiles(@"C:\").Contains(_file1));
        }
        [Test]
        public void Test_Count_equal_2()
        {
            Assert.AreEqual(mockObj.Object.GetFiles(@"C:\").Count, 2);
        }
        [Test]
        public void Test_Not_Null()
        {
            Assert.IsNotNull(mockObj.Object.GetFiles(@"C:\"));
        }
    }

}