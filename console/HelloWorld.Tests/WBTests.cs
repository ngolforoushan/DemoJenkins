using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class WBTests
    {
        [TestMethod]
        public void CheckMessageContent()
        {
            Assert.AreEqual(Program.CreateWelcomeMssage(), "Hello World! --NG");
        }

        public void CheckAddFunctionality() {
            Assert.AreEqual<double>(Program.Calculater(2.0f, 3.0f, "add"), 5f);
        }
    }
}
