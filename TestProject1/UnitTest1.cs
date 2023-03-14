using System;
using Classes;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, 10, 0.0001);  //are equal what you expect; the second argument; the Delta of 0.0001 is margin of error
        }
    }
}