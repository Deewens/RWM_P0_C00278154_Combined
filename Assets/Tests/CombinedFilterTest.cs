using NUnit.Framework;

public class CombinedFilterTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CombinedFilterSimple()
    {
        int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
        int[] output = CombinedFilter.combinedFilter(input);
        int[] expected = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        CollectionAssert.AreEqual(expected, output);
    }
}
