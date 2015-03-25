namespace MainApp
{
    using System;

    public class Group
    {
        public int GroupNumber { get; private set; }
        public string Department { get; private set; }
        public Group(int groupNumber, string department)
        {
            this.GroupNumber = groupNumber;
            this.Department = department;
        }

    }
}
