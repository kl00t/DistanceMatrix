namespace DistanceMatrix.Core.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StringHelper
    {
        public static List<string> SplitStringToList(char delimiter, string stringToSplit)
        {
            return string.IsNullOrEmpty(stringToSplit) ? new List<string>() : stringToSplit.Split(delimiter).ToList();
        }

        public static string[] SplitStringToArray(char delimiter, string stringToSplit)
        {
            return string.IsNullOrEmpty(stringToSplit) ? new string[0] : stringToSplit.Split(delimiter).ToArray();
        }

        public static string ConvertListToString(string separator, List<string> listToConvert)
        {
            if (listToConvert == null || !listToConvert.Any())
            {
                return string.Empty;
            }

            return string.Join(separator, listToConvert);
        }

        public static bool DoesStringExistInList(string value, List<string> list)
        {
            if (string.IsNullOrEmpty(value) || !list.Any())
            {
                return false;
            }

            // Matches any part of string, not just the whole string, and also ignore the case.
            return list.Any(x => value.Contains(x, StringComparison.InvariantCultureIgnoreCase));
        }

        public static List<string> ConvertArrayToList(string[] stringArray)
        {
            return stringArray.ToList();
        }
    }
}