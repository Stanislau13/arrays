namespace excersise6;

public class SupportStaff : UniversityEmployee
{
    public string Position { get; set; }
        public SupportStaff(string position, Person person, string id) 
        : base(person, id)
    {
        Position = position;
    }
    public override string GetOfficialDuties()
    {
        return Position;
    }
}
