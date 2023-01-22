using System.Data;
using System.Xml.Linq;

namespace excersise6;

internal abstract class UniversityEmployee: IComparable
{
    public Person Person { get; set; }

    //task 6.1
    private string _taxID;
    public string TaxID 
    {
        get 
        {
            return _taxID;
        }
        set
        {
            ValidateTaxID(value);
            _taxID = value;
        }
    }

    private static void ValidateTaxID(string value)
    {
        if (Int32.Parse(value) < 0)
        {
            throw new ArgumentException("Wrong ID");
        }
    }

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
    public int CompareTo(object obj)
    {
        if (obj is null) return -1;

        UniversityEmployee otherUniversityEmployee = (UniversityEmployee) obj;
        return otherUniversityEmployee.Person.GetFirstAndLastNameLength().CompareTo(Person.GetFirstAndLastNameLength());
    }
}


