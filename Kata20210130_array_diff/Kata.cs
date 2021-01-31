using System.Collections.Generic;

namespace Kata20210130_array_diff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] aArr, int[] bArr)
        {
            List<int> actual = new List<int>();
            for (int i = 0; i < aArr.Length; i++)
            {
                bool equalBarr = false;
                for (int j = 0; j < bArr.Length; j++)
                {
                    if (aArr[i] == bArr[j])
                    {
                        equalBarr = true;
                    }

                }

                if (equalBarr == false)
                {
                    actual.Add(aArr[i]);
                }

            }

            int[] actualArr = actual.ToArray();



            return actualArr;
        }
    }
}