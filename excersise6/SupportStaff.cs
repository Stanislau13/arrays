using System;

namespace excersise6;

internal class SupportStaff : UniversityEmployee
{
    public string Position { get; set; }
        public SupportStaff(string position, Person person, int id) 
        : base(person, id)
    {
        Position = position;
    }
    public override string GetOfficialDuties()
    {
        return Position;
    }
}
