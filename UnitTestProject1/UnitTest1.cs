using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FixTest()
        {
            //Arrange  
            string text = "1/10";
            string expected = "1/10";
            //Act
            FixResult obj = new FixResult();
            string actual = obj.FixWrongResult(text);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
