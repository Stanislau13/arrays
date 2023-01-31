using excersise6;

namespace UniversityUnitTests;

[TestClass]
public class SupportStuffUnitTest
{
    [TestMethod]
    public void CheckGetOfficialDutiesPositive()
    {
        SupportStaff support = new("Driver", null, "001");
        
        Assert.AreEqual(support.GetOfficialDuties(), "Driver");
    }
}
