using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTextEncryption()
        {
            Assert.AreEqual(new Simple_Table_Permutation.MyPair("lyr! lmo! e wd Ho l!", "5-4"), Simple_Table_Permutation.Table_Permutation.TextEncryption("Hello my world!!!"));
        }

        [Test]
        public void TestTextDecryption()
        {
            Assert.AreEqual("Hello my world!!!", Simple_Table_Permutation.Table_Permutation.TextDecryption("lyr! lmo! e wd Ho l!", "5-4"));
        }

    }
}