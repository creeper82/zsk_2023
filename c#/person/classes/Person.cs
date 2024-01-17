namespace Program;

public class Person(string firstName, string lastName, DateTime dateOfBirth, Address address)
{
    public string FirstName = firstName;
    public string LastName = lastName;
    public DateTime DateOfBirth = dateOfBirth;
    public Address PersonAddress = address;

    public int Age
    {
        get { return (int)(DateTime.Now - DateOfBirth).TotalDays / 365; }
    }

    public string GetFullName() => $"{FirstName} {LastName}";
}