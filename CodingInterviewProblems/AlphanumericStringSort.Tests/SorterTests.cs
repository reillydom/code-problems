using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphanumericStringSort.Tests
{
    [TestClass]
    public class SorterTests
    {
        

        [TestMethod]
        public void OrderByASCIIAndSort_Returns_In_Correct_Order()
        {
            // Arrange
            var sorter = new Sorter();
            var valueToSort = "Sorting0123456789";
            var expectedOutcome = "ginortS0246813579";

            // Act
            var sortedValue = sorter.OrderByASCIIAndSort(valueToSort);

            // Assert
            Assert.IsTrue(sortedValue.Equals(expectedOutcome));
        }

        [TestMethod]
        public void OrderByASCIIAndSort_With_No_Value_Returns_EmptyString()
        {
            // Arrange
            var sorter = new Sorter();
            var valueToSort = "";
            var expectedOutcome = "";

            // Act
            var sortedValue = sorter.OrderByASCIIAndSort(valueToSort);

            // Assert
            Assert.IsTrue(sortedValue.Equals(expectedOutcome));
        }


        [TestMethod]
        public void Sort_Returns_In_Correct_Order()
        {
            // Arrange
            var sorter = new Sorter();
            var valueToSort = "Sorting0123456789";
            var expectedOutcome = "ortingS0246813579";

            // Act
            var sortedValue = sorter.Sort(valueToSort);

            // Assert
            Assert.IsTrue(sortedValue.Equals(expectedOutcome));
        }


        [TestMethod]
        public void Sort_With_No_Value_Returns_EmptyString()
        {
            // Arrange
            var sorter = new Sorter();
            var valueToSort = "";
            var expectedOutcome = "";

            // Act
            var sortedValue = sorter.Sort(valueToSort);

            // Assert
            Assert.IsTrue(sortedValue.Equals(expectedOutcome));
        }


    }
}
