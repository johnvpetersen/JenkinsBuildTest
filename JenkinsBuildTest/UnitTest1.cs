using System;
using NUnit;
using NUnit.Framework;

namespace JenkinsBuildTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {

            var x = true;

            Assert.IsTrue(x);

        }
    }
}
