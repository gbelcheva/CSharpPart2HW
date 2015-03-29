namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>, IComparable
    {
        private const int mask = 1;
        private const int maxIndex = 63;
        public ulong Number { get; private set; }
        public BitArray64(ulong number)
        {
            this.Number = number;
        }
        public int this[int index]
        {
            get 
            {
                if (index < 0 || maxIndex < index)
                {
                    throw new ArgumentOutOfRangeException("Index should be int the range [0," + maxIndex + "]");
                }
                return mask & (int)(this.Number >> index);
            }
            set
            {
                if (index < 0 || maxIndex < index)
                {
                    throw new ArgumentOutOfRangeException("Index should be int the range [0," + maxIndex + "]");
                }
                this.Number = ((ulong)mask << index) ^ this.Number;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            return this.Number == (obj as BitArray64).Number;
        }
        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public static bool operator ==(BitArray64 bArr1, BitArray64 bArr2)
        {
            return bArr1.Number == bArr2.Number;
        }
        public static bool operator !=(BitArray64 bArr1, BitArray64 bArr2)
        {
            return !(bArr1 == bArr2);
        }
    }
}
