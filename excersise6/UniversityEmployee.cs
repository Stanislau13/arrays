namespace excersise6;

internal abstract class UniversityEmployee
{
    public Person Person { get; set; }
    public string TaxID { get; set; }

    public UniversityEmployee(Person person, string id) 
    {
        Person = person;
        TaxID = id;
    }
    public abstract string GetOfficialDuties();
    public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        UniversityEmployee otherEmpooyee = (UniversityEmployee)other;
        return this == other || (TaxID.Equals(otherEmpooyee.TaxID));
    }

    public override string ToString()
    {        
        return $"{Person.FirstName} {Person.LastName} {TaxID}"; 
    }
}


