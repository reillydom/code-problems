using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramDetection.Tests
{
    [TestClass]
    public class AnagramDetectorTests
    {
        [TestMethod]
        public void IsAnagram_Returns_True_For_Valid_Anagram()
        {
            // Arrange
            var anagramDetector = new AnagramDetector();
            // Act
            var isAnagram = anagramDetector.IsAnagram("pastel", "plates");

            // Assert
            Assert.IsTrue(isAnagram);
        }

        [TestMethod]
        public void IsAnagram_Returns_False_For_InValid_Anagram()
        {
            // Arrange
            var anagramDetector = new AnagramDetector();
            // Act
            var isAnagram = anagramDetector.IsAnagram("pastel", "plAtes");

            // Assert
            Assert.IsFalse(isAnagram);
        }



        [TestMethod]
        public void GetNumberOfAnagramOccurences_Returns_ExpectedValue()
        {
            // Arrange
            var anagramDetector = new AnagramDetector();
            // Act
            var numberOfOccurences = anagramDetector.GetNumberOfAnagramOccurences("cbaebabacd", "abc");

            // Assert
            Assert.IsTrue(numberOfOccurences == 2);
        }



        [TestMethod]
        public void GetNumberOfAnagramOccurences_Returns_Zero()
        {
            // Arrange
            var anagramDetector = new AnagramDetector();
            // Act
            var numberOfOccurences = anagramDetector.GetNumberOfAnagramOccurences("cbaebabacd", "acc");

            // Assert
            Assert.IsTrue(numberOfOccurences == 0);
        }



    }
}
