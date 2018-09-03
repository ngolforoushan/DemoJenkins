using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class WBTests
    {
        [TestMethod]
        public void CheckMessageContent()
        {
            Assert.AreEqual(Program.CreateWelcomeMessage(), "Hello World! --NG");
        }
    }
}
