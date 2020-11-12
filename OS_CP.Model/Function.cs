namespace OS_CP.Model
{
    /// <summary>
    /// Class of program with Model
    /// </summary>
    public sealed class Function : IFunction
    {
        private int _size; //Size of function value 

        /// <summary>
        /// Getting and setting function value table size 
        /// </summary>
        public int Size
        {
            get => _size;
            set
            {
                _size = value;
                Table = new double[_size][];
                for (int i = 0; i < _size; i++)
                {
                    Table[i] = new double[3];
                }
            }
        }

        /// <summary>
        /// Getting function value table 
        /// </summary>
        public double[][] Table { get; private set; }

        /// <summary>
        /// Getting and setting i,j element of function value table
        /// </summary>
        /// <param name="i"> Row index </param>
        /// <param name="j"> Column index </param>
        /// <returns></returns>
        public double this[int i, int j] { get => Table[i][j]; set => Table[i][j] = value; }

        /// <summary>
        /// Fill function value table
        /// </summary>
        /// <param name="table"> value table </param>
        public void FillTable(double[][] table)
        {
            this.Size = table.Length;
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.Table[i][j] = table[i][j];
                }
            }
        }
    }
}
