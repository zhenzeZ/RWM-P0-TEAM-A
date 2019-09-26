using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Comb
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CombSimplePasses()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 4, 5, 13, 15, 24, 28, 38, 33, 44, 50, 50 };
            // Use the Assert class to test conditions

            CollectionAssert.AreEqual(expected, output);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CombWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
