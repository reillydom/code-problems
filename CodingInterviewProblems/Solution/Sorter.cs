using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlphanumericStringSort
{
    public class Sorter
    {
        /// <summary>
        /// Returns the argument ordered by ASCII and then sorted in the following order:
        /// 1) sorted Lower case
        /// 2) sorted upper case
        /// 3) sorted even digits
        /// 4) sorted off digits. 
        /// </summary>
        /// <param name="valueToSort"></param>
        /// <returns></returns>
        public string OrderByASCIIAndSort(string valueToSort)
        {
            // Order:
            // 1) sorted Lower case
            // 2) sorted upper case
            // 3) sorted even digits
            // 4) sorted odd digits. 
            var argumentSortedByCharOrder = valueToSort.OrderBy(x => x);

            var lowerCaseValues = "";
            var upperCaseValues = "";
            var evenDigits = "";
            var oddDigits = "";

            var sortedStringBuilder = new StringBuilder();
            foreach(var character in argumentSortedByCharOrder)
            {
                if (char.IsWhiteSpace(character)) { continue; }

                if(char.IsLower(character))
                {
                    lowerCaseValues += character;
                }
                if(char.IsUpper(character))
                {
                    upperCaseValues += character;
                }
                if(char.IsDigit(character))
                {
                    try
                    {
                        var parsedCharacterToDigit = char.GetNumericValue(character);
                        if(parsedCharacterToDigit %2 == 0)
                        {
                            // Even
                            evenDigits += character;
                        }
                        else
                        {
                            // odd. 
                            oddDigits += character;
                        }


                    }
                    catch(Exception ex)
                    {
                        // silent fall. 
                    }
                }
            }
            return $"{lowerCaseValues}{upperCaseValues}{evenDigits}{oddDigits}";
        }


        /// <summary>
        /// Returns the argument sorted in the following order:
        /// 1) sorted Lower case
        /// 2) sorted upper case
        /// 3) sorted even digits
        /// 4) sorted off digits. 
        /// </summary>
        /// <param name="valueToSort"></param>
        /// <returns></returns>
        public string Sort(string valueToSort)
        {
            // Order:
            // 1) sorted Lower case
            // 2) sorted upper case
            // 3) sorted even digits
            // 4) sorted odd digits. 
            var characters = valueToSort.ToCharArray();

            var lowerCaseValues = "";
            var upperCaseValues = "";
            var evenDigits = "";
            var oddDigits = "";

            var sortedStringBuilder = new StringBuilder();
            foreach (var character in characters)
            {
                if (char.IsWhiteSpace(character)) { continue; }

                if (char.IsLower(character))
                {
                    lowerCaseValues += character;
                }
                if (char.IsUpper(character))
                {
                    upperCaseValues += character;
                }
                if (char.IsDigit(character))
                {
                    try
                    {
                        var parsedCharacterToDigit = char.GetNumericValue(character);
                        if (parsedCharacterToDigit % 2 == 0)
                        {
                            // Even
                            evenDigits += character;
                        }
                        else
                        {
                            // odd. 
                            oddDigits += character;
                        }


                    }
                    catch (Exception ex)
                    {
                        // silent fall. 
                    }
                }
            }
            return $"{lowerCaseValues}{upperCaseValues}{evenDigits}{oddDigits}";
        }




    }
}
