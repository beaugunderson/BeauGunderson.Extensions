using Microsoft.VisualStudio.TestTools.UnitTesting;

using BeauGunderson.Extensions;

namespace ExtensionsTests
{
    [TestClass]
    public class StructuralEqualsTests
    {
        [TestMethod]
        public void StructuralEqualsTest()
        {
            var a = new[]
            {
                1, 2, 3
            };

            var b = new[]
            {
                1, 2, 3
            };
         
            Assert.IsFalse(a.Equals(b));
            Assert.IsTrue(a.EqualsStructure(b));
        }
    }
}