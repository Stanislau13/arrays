using System.Net;

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
    public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        return this == other || Assignment.Equals(((Room)other).Assignment);
    }
}
