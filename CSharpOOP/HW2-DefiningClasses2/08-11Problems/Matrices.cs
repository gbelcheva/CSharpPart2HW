namespace Matrix
{
    using System;
    using System.Text;

    
    class Matrices
    {
        [Version(2, 8)]
        public class Matrix<T> where T : IComparable<T>
        {
            private T[,] matrix;
            public int Row {get; private set;}
            public int Col {get; private set;}

            public Matrix(int row, int col)
            {
                this.Row = row;
                this.Col = col;
                this.matrix = new T[this.Row, this.Col];

            }

            public T this[int row, int col]
            {
                get 
                {
                    return this.matrix[row, col];
                }
                set 
                {
                    if (0 > row || 0 > col || row > (this.Row - 1) || col > (this.Col - 1))
                    {
                        throw new IndexOutOfRangeException("The row or column index is out of range");
                    }
                    this.matrix[row, col] = value;
                }
 
            }
            public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
            {
                if (m1.Row != m2.Row || m1.Col != m2.Col)
                {
                    throw new ArgumentException("Matrices cannot have different dimensions");
                }
                var result = new Matrix<T>(m1.Row, m1.Col);
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                    }
                }
                return result;
            }

            public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
            {
                if (m1.Row != m2.Row || m1.Col != m2.Col)
                {
                    throw new ArgumentException("Matrices cannot have different dimensions");
                }
                var result = new Matrix<T>(m1.Row, m1.Col);
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                    }
                }
                return result;
            }
            public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
            {
                if (m1.Col != m2.Row)
                {
                    throw new ArgumentException("First matrix number of columns should be equal to second matrix number of rows");
                }
                var result = new Matrix<T>(m1.Row, m2.Col);
                for (int i = 0; i < result.Row; i++)
                {
                    for (int j = 0; j < result.Col; j++)
                    {
                        for (int k = 0; k < m1.Col; k++)
                        {
                            result[i, j] += (dynamic)m1[i, k] * (dynamic)m2[k, j];
                        }
                    }
                }
                return result;
            }

            public static bool operator true(Matrix<T> m)
            {
                for (int i = 0; i < m.Row; i++)
                {
                    for (int j = 0; j < m.Col; j++)
                    {
                        if (m[i, j].Equals(0))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            public static bool operator false(Matrix<T> m)
            {
                for (int i = 0; i < m.Row; i++)
                {
                    for (int j = 0; j < m.Col; j++)
                    {
                        if (m[i, j].Equals(0))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < this.Col; j++)
                    {
                        sb.Append(this.matrix[i, j].ToString().PadLeft(4, ' '));
                    }
                    sb.Append("\n\r\n\r");
                    
                }
                return sb.ToString();
            }

        }
        static void Main()
        {
            var m1 = new Matrix<int>(2, 4);
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m1.Col; j++)
                {
                    m1[i, j] = i + j;
                }
            }
            var m2 = new Matrix<int>(2, 4);
            for (int i = 0; i < m2.Row; i++)
            {
                for (int j = 0; j < m2.Col; j++)
                {
                    m2[i, j] = i + j*2 + 1;
                }
            }
            Console.WriteLine("matrix1 = \n{0}", m1);
            Console.WriteLine("matrix2 = \n{0}", m2);

            Console.WriteLine("sum = \n{0}", m1 + m2);
            Console.WriteLine("difference = \n{0}", m1 - m2);

            m1 = new Matrix<int>(4, 2);
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m1.Col; j++)
                {
                    m1[i, j] = i + j;
                }
            }
            m2 = new Matrix<int>(2, 4);
            for (int i = 0; i < m2.Row; i++)
            {
                for (int j = 0; j < m2.Col; j++)
                {
                    m2[i, j] = i + j * 2 + 1;
                }
            }
            Console.WriteLine("matrix1 = \n{0}", m1);
            Console.WriteLine("matrix2 = \n{0}", m2);
            Console.WriteLine("product = \n{0}", m1 * m2);

            Console.WriteLine("Are all elements in matraix2 non-zero?");
            if (m2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("Are all elements in matraix1 non-zero?");
            if (m1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("check version attribute");
            Type type = typeof(Matrix<string>);
            object[] attributes = type.GetCustomAttributes(false);
            for (int i = 0; i < attributes.Length - 1; i++)
            {
                Console.WriteLine(attributes[i]);
            }


        }
    }
}
