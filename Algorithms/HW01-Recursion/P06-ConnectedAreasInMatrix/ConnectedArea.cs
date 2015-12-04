namespace P06_ConnectedAreasInMatrix
{
    using System;

    public class ConnectedArea : IComparable
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Size { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) 
            {
                return -1;
            }

            ConnectedArea otherConnectedArea = obj as ConnectedArea;

            if (otherConnectedArea != null)
            {
                int bySize = -1 * this.Size.CompareTo(otherConnectedArea.Size);
                int byRow = this.Row.CompareTo(otherConnectedArea.Row);
                int byCol = this.Col.CompareTo(otherConnectedArea.Col);

                if (bySize == 0)
                {
                    if (byRow == 0)
                    {
                        return byCol;
                    }

                    return byRow;
                }

                return bySize;
            }
            else
            {
                throw new ArgumentException("Object is not a ConnectedArea.");
            }
        }

        public override string ToString()
        {
            return string.Format("Area at ({0}, {1}), size: {2}", this.Row, this.Col, this.Size);
        }
    }
}
