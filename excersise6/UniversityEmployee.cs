namespace excersise6;
internal abstract class UniversityEmployee: IComparable
{
    public Person Person { get; set; }

    //task 6.1
    private string _taxId;
    public string TaxId 
    {
        get 
        {
            return _taxId;
        }
        set
        {
            ValidateTaxId(value);
            _taxId = value;
        }
    }

    private static void ValidateTaxId(string value)
    {
        if (int.TryParse(value, out int result))
        {
            if (result < 0) 
            {
                throw new ArgumentException("Wrong ID");
            }
            return;
        }
        throw new ArgumentException("Cannot parse");
    }

    public UniversityEmployee(Person person, string id) 
    {
        Person = person;
        TaxId = id;
    }

    public abstract string GetOfficialDuties();

    public override bool Equals(Object other)
    {
        if (other == null || ! other.GetType().Equals(typeof(UniversityEmployee)))
        {
            return false;
        }
        UniversityEmployee otherEmpooyee = (UniversityEmployee)other;
        return this == other || (TaxId.Equals(otherEmpooyee.TaxId));
    }

        public override int GetHashCode()
    {
        return TaxId.GetHashCode();  
    }

    public override string ToString()
    {        
        return $"{Person.FirstName} {Person.LastName} {TaxId}"; 
    }

    public int CompareTo(object obj)
    {
        if (obj is null) return -1;

        UniversityEmployee otherUniversityEmployee = (UniversityEmployee) obj;
        return otherUniversityEmployee.Person.GetFirstAndLastNameLength().CompareTo(Person.GetFirstAndLastNameLength());
    }
}


