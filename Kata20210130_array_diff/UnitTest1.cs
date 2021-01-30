using System.Collections.Generic;
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
        public void Test1()
        {
            var actual =Kata.ArrayDiff(new int[] {1,2}, new int[] {1});
            Assert.AreEqual(new int[] {2}, actual);
        }
    }

    public class Kata
    {
        public static List<int> ArrayDiff(int[] aArr, int[] bArr)
        {
            List<int> actual = new List<int>();
            for (int i = 0; i < aArr.Length; i++)
            {
                if (aArr[i] != bArr[0])
                {
                    actual.Add(aArr[i]);
                }
            }

            return actual;
        }
    }
}