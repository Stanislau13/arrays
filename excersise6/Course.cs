namespace excersise6;

internal class Course
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Course(string courseName, string courseDescription) 
    {
        Name = courseName;
        Description = courseDescription;
    }
}
