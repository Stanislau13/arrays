namespace excersise6;

internal class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PersonAddress { get; set; }
    public Person(string firstName, string lastName, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        PersonAddress = address;
    }
}
