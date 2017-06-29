// ReSharper disable once CheckNamespace
namespace System
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether [contains] [the specified to check].
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="toCheck">To check.</param>
        /// <param name="comp">The comp.</param>
        /// <returns>
        /// Returns the result of the contains.
        /// </returns>
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
