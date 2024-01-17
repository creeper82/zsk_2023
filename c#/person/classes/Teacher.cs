namespace Program;

public class Teacher(string firstName, string lastName, DateTime dateOfBirth, Address address, List<string> subjects) : Person(firstName, lastName, dateOfBirth, address)
{
    public List<string> Subjects = subjects;
}