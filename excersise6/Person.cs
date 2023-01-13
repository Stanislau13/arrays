using System.Xml.Linq;

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
    public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        Person otherPerson = (Person) other;
        return this == other || (FirstName.Equals(otherPerson.FirstName) && LastName.Equals(otherPerson.LastName));
    }
}
