namespace Matrix
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
    class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        public override string ToString()
        {
            return "v" + this.Major + "." + this.Minor;
        }
    }
}