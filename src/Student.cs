namespace ScannerProject
{
    internal class Student : Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string ParentEmail { set; get; }

        public Student(string _lastName, string _firstName, int id, string _parentEmail) : base(id)
        {
            LastName = _lastName;
            FirstName = _firstName;
            ParentEmail = _parentEmail;
        }
    }
}