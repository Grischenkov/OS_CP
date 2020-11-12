namespace OS_CP.Model
{
    /// <summary>
    /// Interface for model
    /// </summary>
    public interface IFunction
    {
        /// <summary>
        /// Getting and setting function value table size
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// Getting function value table
        /// </summary>
        double[][] Table { get; }

        /// <summary>
        /// Getting and setting i,j element of function value table
        /// </summary>
        /// <param name="i"> Row index </param>
        /// <param name="j"> Column index </param>
        /// <returns></returns>
        double this[int i, int j] { get; set; }
    }
}
