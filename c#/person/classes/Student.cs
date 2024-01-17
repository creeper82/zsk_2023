namespace Program;

public class Student(string firstName, string lastName, DateTime dateOfBirth, Address address, int studentNumber) : Person(firstName, lastName, dateOfBirth, address)
{
    public int StudentNumber = studentNumber;
}