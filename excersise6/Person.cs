namespace excersise6;

internal class Person
{
    private string _firstName;
    public string FirstName 
    {
        get 
        { 
           return _firstName;
        }
        set
        {
            ValidateStringLength(value, LastName);
            _firstName = value;
        }
    }

    private string _lastName;
        public string LastName 
    {
        get
        {
            return _lastName;
        }
        set
        {
            ValidateStringLength(FirstName, value);
            _lastName = value;
        }
    }

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

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public int GetFirstAndLastNameLength()
    {
        return GetFirstAndLastNameLength(FirstName, LastName);
    }

    private int GetNameLanghts(string name) 
    {
        if (name is null)
        {
            return 0;
        }
        return name.Length;
    }

    private void ValidateStringLength(string firstName, string lastName)
    {
        if (GetFirstAndLastNameLength(firstName, lastName) > 15)
        {
            throw new ArgumentException("A last name and first name length of more than 15 characters");
        }
    }

    private int GetFirstAndLastNameLength(string firstName, string lastName)
    {
        return (GetNameLanghts(firstName) + GetNameLanghts(lastName));
    }
}
