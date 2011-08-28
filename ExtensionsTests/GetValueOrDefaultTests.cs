using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using BeauGunderson.Extensions;

namespace ExtensionsTests
{
    [TestClass]
    public class GetValueOrDefaultTests
    {
        private readonly Dictionary<string, int> _testDictionary = 
            new Dictionary<string, int>
            {
                { "key-1", 100 },
                { "key-2", 200 },
                { "key-3", 300 },
                { "key-4", 400 },
            };

        [TestMethod]
        public void GetValueOrDefaultTest()
        {
            int i1 = _testDictionary.GetValueOrDefault("key-1");
            int i2 = _testDictionary.GetValueOrDefault("key-5");
        
            Assert.AreEqual(100, i1);
            Assert.AreEqual(0, i2);
        }
    }
}
