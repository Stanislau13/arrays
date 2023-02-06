using excersise6;

namespace UniversityUnitTests;

[TestClass]
public class TeacherUnitTest
{
    [TestMethod]
    public void CheckGetOfficialDutiesPositive()
    {
        Course course = new("Physic", null);
        Teacher teacher1 = new(course, null, "001");

        Assert.AreEqual(teacher1.GetOfficialDuties(), "Physic");
    }
}
