using BeauGunderson.Extensions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTests
{
    [TestClass]
    public class StringSliceTests
    {
        private const string TestString = "The quick brown fox jumped over the lazy dog.";

        [TestMethod]
        public void StringSliceTest()
        {
            string s1 = TestString.Slice(0, 9);
            string s2 = TestString.Slice(10, 15);

            Assert.AreEqual("The quick", s1);
            Assert.AreEqual("brown", s2);
        }

        [TestMethod]
        public void NegativeStringSliceTest()
        {
            string s1 = TestString.Slice(0, -5);
            string s2 = TestString.Slice(4, -5);

            Assert.AreEqual("The quick brown fox jumped over the lazy", s1);
            Assert.AreEqual("quick brown fox jumped over the lazy", s2);
        }
    }
}
