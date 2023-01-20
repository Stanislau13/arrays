namespace excersise6;

internal class DegreeTeacher : Teacher
{
    public string Degree { get; set; }
    public string Rank { get; set; }
    public DegreeTeacher(string degree, string rank, Course course, Person person, string id)
        : base(course, person, id)
    {
        Degree = degree;
        Rank = rank;
    }
}
