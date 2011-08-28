using System.Linq;

using BeauGunderson.Extensions;
using BeauGunderson.Extensions.Debugging;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionsTests
{
    [TestClass]
    public class GenericArraySliceTests
    {
        private readonly int[] _testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod]
        public void GenericArraySliceTest()
        {
            int[] a1 = _testArray.Slice(0, 5);
            int[] a2 = _testArray.Slice(2, 4);

            a1.PrettyPrint("a1");
            a2.PrettyPrint("a2");

            Assert.AreEqual(5, a1.Length);
            Assert.AreEqual(2, a2.Length);

            Assert.IsTrue(a1.SequenceEqual(new[] { 1, 2, 3, 4, 5 }));
            Assert.IsTrue(a2.SequenceEqual(new[] { 3, 4 }));
        }

        [TestMethod]
        public void NegativeGenericArraySliceTest()
        {
            int[] a1 = _testArray.Slice(0, -2);
            int[] a2 = _testArray.Slice(2, -4);

            a1.PrettyPrint("a1");
            a2.PrettyPrint("a2");

            Assert.AreEqual(8, a1.Length);
            Assert.AreEqual(4, a2.Length);

            Assert.IsTrue(a1.SequenceEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
            Assert.IsTrue(a2.SequenceEqual(new[] { 3, 4, 5, 6 }));
        }
    }
}