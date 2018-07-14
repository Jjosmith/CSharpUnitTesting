using NUnit.Framework;
using SimpleConsoleApp;

namespace SimpleConsoleAppTests
{
    [TestFixture]
    public class SimpleConsoleAppTests
    {
        [Test]
        public void AdditionTest()
        {
            SimpleClass sup = new SimpleClass();

            int result = sup.Add(20, 10);

            Assert.AreEqual(30, result);
        }

        [Test]
        public void ReturnsStringTest()
        {
            SimpleClass sup = new SimpleClass();

            string result = sup.Concat("Hello", "World");

            StringAssert.Contains(result, "Hello World");
        }
    }
}
