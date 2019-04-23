using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class TestNumberTest
  {
    [TestMethod]
    public void IsTestNumber_NumberDivisibleByThree_True()
    {
      TestNumber testTestNumber = new TestNumber();

      Assert.AreEqual ("Ping", testTestNumber.IsTestNumber(9));

    }
    [TestMethod]
    public void IsTestNumber_NumberDivisibleByFive_True()
    {
      TestNumber testTestNumber = new TestNumber();
      Assert.AreEqual("Pong", testTestNumber.IsTestNumber(12));
    }
  }
}
