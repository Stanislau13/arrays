namespace excersise6;

internal class Building
{   
    public string Address { get; set; }
    public Room[] Rooms { get; set; }

    public Building(string address, Room[] rooms) 
    { 
        Address = address;
        Rooms = rooms;
    }
}
