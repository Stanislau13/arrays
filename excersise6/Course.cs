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

    public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        return this == other || Name.Equals(((Course)other).Name);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
