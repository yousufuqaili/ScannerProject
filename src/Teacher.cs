namespace ScannerProject
{
    internal class Teacher : Person
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Password { get; }

        public Teacher(string lastName, string firstName, int id, string password) : base(id)
        {
            LastName = lastName;
            FirstName = firstName;
            Password = password;
        }
    }
}