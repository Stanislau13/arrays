using System.Dynamic;

namespace excersise6;

internal class Building
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
        return this == other || Address.Equals(((Building) other).Address);
    }
}
