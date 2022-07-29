namespace FilterByPredicate
{
    /// <summary>
    /// Presents predicate.
    /// </summary>
    public interface IPredicate
    {
        /// <summary>
        /// Presents function-predicate for integer.
        /// </summary>
        /// <param name="number">Integer to be verify.</param>
        /// <returns>Result of verifying.</returns>
        bool Verify(int number);
    }
}
