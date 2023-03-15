using Technology;
namespace TechnologyTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestDropPhone() 
        {
            SmartPhone lindasPhone = new SmartPhone(64, 8, "Apple");
            lindasPhone.DropPhone();
            Assert.IsFalse(lindasPhone.HasCamera);
        }

        [TestMethod]
        public void TestStuffCheetosInLaptop() 
        {
            Laptop lindasLaptop = new Laptop(4, 64, 16, "PC");
            lindasLaptop.StuffCheetos(2);
            Assert.AreEqual(2, lindasLaptop.NumOfUsb, .001);

        }
    }
}