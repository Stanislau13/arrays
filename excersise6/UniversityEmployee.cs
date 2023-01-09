namespace excersise6;

internal abstract class UniversityEmployee
{
    public Person Person { get; set; }
    public int TaxID { get; set; }

    public UniversityEmployee(Person person, int id) 
    {
        Person = person;
        TaxID = id;
    }
    public abstract string GetOfficialDuties();
}

