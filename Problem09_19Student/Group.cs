using System;

namespace Problem09_19Student
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }
        public string DepartmentName
        {
            get { return this.departmentName; }
            set { this.departmentName = value; }
        }
        public Group(int groupeN,string departmentN)
        {
            this.GroupNumber = groupeN;
            this.DepartmentName = departmentN;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}",this.groupNumber,this.departmentName);
        }
    }
}
