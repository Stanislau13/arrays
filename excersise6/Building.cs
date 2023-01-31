namespace excersise6;

public class Building
{
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }

    public Building(string address, List<Room> rooms)
    {
        Address = address;
        Rooms = rooms;
    }

    public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        return this == other || Address.Equals(((Building)other).Address);
    }

    public override int GetHashCode()
    {
        return Address.GetHashCode();
    }

    public bool AddRoom(Room newRoom)
    {
        foreach (Room room in Rooms)
        {
            if (room.Equals(newRoom))
            {
                return false;
            }
        }
        Rooms.Add(newRoom);
        return true;
    }
}