using Microsoft.VisualStudio.TestTools.UnitTesting;

using BeauGunderson.Extensions;

namespace ExtensionsTests
{
    [TestClass]
    public class CompareStructureTo
    {
        [TestMethod]
        public void CompareStructureToTest()
        {
            var a = new[]
            {
                1, 3, 3
            };
            
            var b = new[]
            {
                1, 2, 3
            };
            
            Assert.AreEqual(1, a.CompareStructureTo(b));
        }
    }
}