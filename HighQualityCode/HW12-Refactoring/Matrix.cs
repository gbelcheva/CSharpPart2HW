namespace HW13Refactoring
{
    using System;
    using System.Text;

    public class Matrix
    {
        private const int DirectionsCount = 8;
        private const int MinMatrixSize = 1;
        private const int MaxMatrixSize = 100;
        private const int DefaultMatrixSize = 3;

        private int size;
        private int[,] matrix;
        private int currentRow = 0;
        private int currentCol = 0;

        /// <summary>
        /// Creates a matrix with a given size.
        /// </summary>
        /// <param name="size">The size of the matrix.</param>
        public Matrix(int size = DefaultMatrixSize)
        {
            this.Size = size;
            this.matrix = new int[this.size, this.size];
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < MinMatrixSize || MaxMatrixSize < value)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The size of the matrix cannot be {0}. Size must be between {1} and {2}.", value, MinMatrixSize, MaxMatrixSize));
                }

                this.size = value;
            }
        }

        /// <summary>
        /// Fills the matrix according to the rotating walk.
        /// </summary>
        public void FillMatrix()
        {
            int rowDirection = 1;
            int colDirection = 1;
            int cellValue = 1;

            this.FindNextEmptyCell();

            while (true)
            {
                this.matrix[this.currentRow, this.currentCol] = cellValue;

                if (!this.IsCellEmpty(this.currentRow, this.currentCol))
                {
                    this.FindNextEmptyCell();

                    if (this.IsCellEmpty(this.currentRow, this.currentCol))
                    {
                        this.matrix[this.currentRow, this.currentCol] = cellValue++;
                        rowDirection = 1;
                        colDirection = 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int nextRow = this.currentRow + rowDirection;
                int nextCol = this.currentCol + colDirection;

                if (!this.IsInsideMatrix(nextRow) || 
                    !this.IsInsideMatrix(nextCol) || 
                    this.matrix[nextRow, nextCol] != 0)
                {
                    while (!this.IsInsideMatrix(nextRow) || 
                           !this.IsInsideMatrix(nextCol) || 
                           this.matrix[nextRow, nextCol] != 0)
                    {
                        this.ChangeDirection(ref rowDirection, ref colDirection);

                        nextRow = this.currentRow + rowDirection;
                        nextCol = this.currentCol + colDirection;
                    }
                }

                this.currentRow = nextRow;
                this.currentCol = nextCol;

                cellValue++;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    result.AppendFormat("{0,3}", this.matrix[i, j]);
                }

                result.Append(Environment.NewLine + Environment.NewLine);
            }

            return result.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private void FindNextEmptyCell()
        {
            this.currentRow = 0;
            this.currentCol = 0;

            for (int rowIndex = 0; rowIndex < this.Size; rowIndex++)
            {
                for (int colIndex = 0; colIndex < this.Size; colIndex++)
                {
                    if (this.matrix[rowIndex, colIndex] == 0)
                    {
                        this.currentRow = rowIndex;
                        this.currentCol = colIndex;

                        return;
                    }
                }
            }
        }

        private void ChangeDirection(ref int currentRowDir, ref int currentRowCol)
        {
            int[] rowDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int directionChange = 0;
            for (int i = 0; i < DirectionsCount; i++)
            {
                if (rowDirections[i] == currentRowDir && colDirections[i] == currentRowCol)
                {
                    directionChange = i;

                    break;
                }
            }

            if (directionChange == DirectionsCount - 1)
            {
                currentRowDir = rowDirections[0];
                currentRowCol = colDirections[0];

                return;
            }

            currentRowDir = rowDirections[directionChange + 1];
            currentRowCol = colDirections[directionChange + 1];
        }

        private bool IsCellEmpty(int currentRow, int currentCol)
        {
            int[] rowDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < DirectionsCount; i++)
            {
                if (!this.IsInsideMatrix(currentRow + rowDirections[i]))
                {
                    rowDirections[i] = 0;
                }

                if (!this.IsInsideMatrix(currentCol + colDirections[i]))
                {
                    colDirections[i] = 0;
                }
            }

            for (int i = 0; i < DirectionsCount; i++)
            {
                if (this.matrix[currentRow + rowDirections[i], currentCol + colDirections[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInsideMatrix(int rowOrCol)
        {
            return 0 <= rowOrCol && rowOrCol < this.size;
        }
    }
}