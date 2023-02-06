using excersise6;

namespace UniversityUnitTests;

[TestClass]
public class RoomUnitTest
{

    [TestMethod]
    public void CheckEqualsForOneObjectPositive()
    {
        Room room = new(AssignmentType.Auxiliary, 1);

        Assert.IsTrue(room.Equals(room));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithTheSameNumberPositive()
    {
        Room room1 = new(AssignmentType.Auxiliary, 1);
        Room room2 = new(AssignmentType.Laboratory, 1);

        Assert.IsTrue(room1.Equals(room2));
    }

    [TestMethod]
    public void CheckEqualsForObjectAndNullPositive()
    {
        Room room = new(AssignmentType.Auxiliary, 1);

        Assert.IsFalse(room.Equals(null));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithDifferentNumberPositive()
    {
        Room room1 = new(AssignmentType.Auxiliary, 1);
        Room room2 = new(AssignmentType.Auxiliary, 2);

        Assert.IsFalse(room1.Equals(room2));
    }

    [TestMethod]
    public void CheckGetHashCodeForEqualObjectsPositive()
    {
        Room room1 = new(AssignmentType.Auxiliary, 1);
        Room room2 = new(AssignmentType.Auxiliary, 1);

        Assert.IsTrue(room1.Equals(room2));
        Assert.AreEqual(room1.GetHashCode(), room2.GetHashCode());
    }
}
