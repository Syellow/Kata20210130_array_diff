using NUnit.Framework;

namespace Kata20210130_array_diff
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeleteOneElement1()
        {
            var actual =Kata.ArrayDiff(new int[] {1,2}, new int[] {1});
            Assert.AreEqual(new int[] {2}, actual);
        }

        [Test]
        public void DeleteOneElement2()
        {
            var actual = Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] {1});
            Assert.AreEqual(new int[] {2, 2}, actual);
        }

        [Test]
        public void DeleteTwoElement1()
        {
            var actual = Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 });
            Assert.AreEqual(new int[] { 1 }, actual);
        }
        
        [Test]
        public void DeleteNoElement1()
        {
            var actual = Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1, 2 });
            Assert.AreEqual(new int[] {}, actual);
        }

    }
}