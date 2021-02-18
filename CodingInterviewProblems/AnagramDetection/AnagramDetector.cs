using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramDetection
{
    public class AnagramDetector
    {

        public int GetNumberOfAnagramOccurences(string parent, string child)
        {
            var numberOfOccurences = 0;
            if (child.Length > parent.Length) { return numberOfOccurences; }

            // We need to substring the parent string and see if there's any Occurences.
            // Calculate the difference in chars between the parent and the child.
            var differenceBetweenParentAndChild = parent.Length - child.Length;
            var numberOfCharsToTake = child.Length; // store the number of chars that we need to get per substring. 
            for (var x = 0; x < differenceBetweenParentAndChild; x++)
            {
                // Starting from X, take the next number of chars that we need.
                // For example if x was 0, and the number of chars needed was 4, start at 0 and take the next 4 chars.
                var subStringToCheckForAnagram = parent.Substring(x, numberOfCharsToTake);
                if (this.IsAnagram(subStringToCheckForAnagram, child)) // Check if the child is an anagram of the sub string we just got. 
                {
                    numberOfOccurences++;
                }
            }
            return numberOfOccurences;
        }

        public bool IsAnagram(string parent, string child)
        {
            if (!string.IsNullOrWhiteSpace(parent) && !string.IsNullOrWhiteSpace(child))
            {
                // Step 1) Check that the child is not bigger than the parent. 
                if (child.Length <= parent.Length)
                {
                    // Step 2) Ensure that it's not the same word. 
                    if (parent.Equals(child)) { return true; }

                    // Step 3) Convert the parent and child arguments to be char arrays, then we can order by the chars. 
                    var parentCharArray = parent.ToCharArray().OrderBy(x => x);
                    var childCharArray = child.ToCharArray().OrderBy(x => x);

                    return parentCharArray.SequenceEqual(childCharArray);
                }
            }
            return false;



        }

    }
}
