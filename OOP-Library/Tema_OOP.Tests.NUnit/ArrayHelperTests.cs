using NUnit.Framework;
using OOP_Library.Library;

namespace Tema_OOP.Tests.NUnit
{
    public class ArrayHelperTests
    {
        [Test]
        public void FibonacciSequence()
        {
            int[] array = {1, 5, 8, 6, 8, 3, 5, 8, 4};
            int[] frecventa = ArrayHelper.frecventa();
            Assert.AreEqual((1, 2, 3, 1, 3, 1, 2, 3, 1), frecventa );
        }
    }
}