using excersise6;

namespace UniversityUnitTests;

[TestClass()]
public class BuildingTest
{
    [TestMethod]
    public void CheckEqualsForOneObjectPositive()
    {
        Building building = new("Address", null);

        Assert.IsTrue(building.Equals(building));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithTheSameAddressPositive()
    {
        Building building1 = new("Address", null);
        Building building2 = new("Address", null);

        Assert.IsTrue(building1.Equals(building2));
    }

    [TestMethod]
    public void CheckEqualsForObjectAndNullPositive()
    {
        Building building = new("Address", null);

        Assert.IsFalse(building.Equals(null));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithDifferentAddressPositive()
    {
        Building building1 = new("Address1", null);
        Building building2 = new("Address2", null);

        Assert.IsFalse(building1.Equals(building2));
    }

    [TestMethod]
    public void CheckGetHashCodeForEqualObjectsPositive()
    {
        Building building1 = new("Address", null);
        Building building2 = new("Address", null);

        Assert.IsTrue(building1.Equals(building2));
        Assert.AreEqual(building1.GetHashCode(), building2.GetHashCode());
    }

    [TestMethod]
    public void CheckAddRoomWithAlreadyAddedRoomPositive()
    {
        Room room = new(AssignmentType.Auxiliary, 1);
        var rooms = new List<Room> { room };
        Building building = new("Address", rooms);

        Assert.IsFalse(building.AddRoom(room));
        Assert.AreEqual(building.Rooms.Count, 1);
    }

    [TestMethod]
    public void CheckAddRoomWithNewRoomPositive()
    {
        Room room1 = new(AssignmentType.Auxiliary, 1);
        Room room2 = new(AssignmentType.Auxiliary, 2);
        var rooms = new List<Room> { room1 };
        Building building = new("Address", rooms);

        Assert.IsTrue(building.AddRoom(room2));
        Assert.AreEqual(building.Rooms.Count, 2);
        Assert.IsTrue(building.Rooms.Contains(room2));
    }
}