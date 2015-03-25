namespace MainApp
{
    using System;
    using System.Text;

    public static class _01StringbuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative");
            }
            if (length < 1 || length + index > sb.Length)
            {
                throw new ArgumentException("Invalid length for substring");
            }
            StringBuilder substring = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                substring.Append(sb[i]);
            }
            return substring;
        }
        
    }
}
