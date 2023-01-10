namespace excersise6;

internal class Room
{
    public AssignmentType Assignment { get; set; }

    public Room(AssignmentType assignment) 
    {
        Assignment = assignment;
    }
    public enum AssignmentType
    {
        Lecture,
        Laboratory,
        Seminar,
        Auxiliary
    }
}
