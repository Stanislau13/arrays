using excersise6;

namespace UniversityUnitTests;

[TestClass()]
public class CourseTest
{
    [TestMethod]
    public void CheckEqualsForOneObjectPositive()
    {
        Course course = new("Physic", null);

        Assert.IsTrue(course.Equals(course));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithTheSameNamePositive()
    {
        Course course1 = new("Physic", "Trututu");
        Course course2 = new("Physic", "Pupupu");

        Assert.IsTrue(course1.Equals(course2));
    }

    [TestMethod]
    public void CheckEqualsForObjectAndNullPositive()
    {
        Course course = new("Physic", null);

        Assert.IsFalse(course.Equals(null));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithDifferentNamePositive()
    {
        Course course1 = new("Nuclear Physics", "Pupupu");
        Course course2 = new("Methphysics", "Pupupu");

        Assert.IsFalse(course1.Equals(course2));
    }

    [TestMethod]
    public void CheckGetHashCodeForEqualObjectsPositive()
    {
        Course course1 = new("Physic", "Trututu");
        Course course2 = new("Physic", "Pupupu");

        Assert.IsTrue(course1.Equals(course2));
        Assert.AreEqual(course1.GetHashCode(), course2.GetHashCode());
    }
}