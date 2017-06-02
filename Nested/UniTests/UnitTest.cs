using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UniTests
{
    using v_mivet_uwp;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.AreEqual(result, 3);
        }
    }
}
