using BeauGunderson.Extensions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTests
{
    [TestClass]
    public class FormatBytesTests
    {
        private const long _testLong = 123456789;

        [TestMethod]
        public void FormatBytesTest()
        {
            string s1 = _testLong.FormatBytes();

            Assert.AreEqual(s1, "117.74 MB");
        }
    }
}