namespace ScannerProject
{
    internal abstract class Person
    {
        // The name of the person
        protected string Name;

        // The ID number of the person, if Id = -1, person !is a student
        protected int Id;

        protected Person(int id)
        {
            Id = id;
        }
    }
}