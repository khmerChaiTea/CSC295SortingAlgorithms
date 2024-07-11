# SortingAlgorithms

Test code for SortingAlgorithms

namespace SortingAlgorithms.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BubbleSort_UnsortedArray_ArrayShouldToBeSorted()
        {
            // AAA - Arrange, Act, Assert // Arrange - setting the test up
            int[] arr1 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            // Act - This is where you call the code you are wanting to test
            Program.BubbleSort(arr1);

            // Assert - is the outcome what you expected
            Assert.AreEqual(arr1[0], 0);
            Assert.AreEqual(arr1[arr1.Length - 1], 100);
            Assert.AreEqual(arr1[7], 56);
        }

        [TestMethod()]
        public void BubbleSort_EmptyArray_ShouldReturnEmptyArray()
        {
            // AAA - Arrange, Act, Assert // Arrange - setting the test up
            int[] arr1 = [];
            // Act - This is where you call the code you are wanting to test
            Program.BubbleSort(arr1);

            // Assert - is the outcome what you expected
            Assert.AreEqual(arr1, []);
        }

        [TestMethod()]
        public void BubbleSort_SortedArray_ArrayShouldToBeSorted()
        {
            // AAA - Arrange, Act, Assert // Arrange - setting the test up
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Act - This is where you call the code you are wanting to test
            int Iteration = Program.BubbleSort(arr1);

            // Assert - is the outcome what you expected
            Assert.AreEqual(arr1[0], 0);
            Assert.AreEqual(arr1[arr1.Length - 1], 10);
            Assert.AreEqual(arr1[7], 7);
            Assert.AreEqual(Iteration, 1);
        }
    }
}
