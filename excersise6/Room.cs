using System.Net;

namespace excersise6;

internal class Room
{
    public AssignmentType Assignment { get; set; }
    public int Number { get; set; }

    public Room(AssignmentType assignment, int number) 
    {
        Assignment = assignment;
        Number = number;
    }

    public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        return this == other || Number.Equals(((Room)other).Number);
    }

    public override int GetHashCode()
    {
        return Number.GetHashCode();
    }
}
