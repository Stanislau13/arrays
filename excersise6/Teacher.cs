namespace excersise6;

internal class Teacher : UniversityEmployee
{
    public Course Course { get; set; }
    public Teacher(Course course, Person person, string id)
        : base(person, id)
    {
        Course = course;
    }
    public override string GetOfficialDuties()
    {
        return Course.Name;
    }
}
