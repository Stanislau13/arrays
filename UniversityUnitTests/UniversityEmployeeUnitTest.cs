using excersise6;

namespace UniversityUnitTests;

[TestClass]
public class UniversityEmployeeUnitTest
{
    [TestMethod]
    public void CheckSetTaxIdPositive()
    {
        Teacher teacher = new();
        teacher.TaxId = "001";

        Assert.AreEqual("001", teacher.TaxId);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Cannot parse")]
    public void CheckSetNonNumberTaxIdNegative()
    {
        Teacher teacher = new();
        teacher.TaxId = "wewe";
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Wrong ID")]
    public void CheckSetNegativTaxIdNegative()
    {
        Teacher teacher = new();
        teacher.TaxId = "-123";
    }

    [TestMethod]
    public void CheckBaseConstructorPositive()
    {
        Teacher teacher = new(null, null, "001");

        Assert.AreEqual("001", teacher.TaxId);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Cannot parse")]
    public void CheckBaseConstructorWithNonNumberTaxIdNegative()
    {
        Teacher teacher = new(null, null, "wewe");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Wrong ID")]
    public void CheckBaseConstructorWithNegativTaxIdNegative()
    {
        Teacher teacher = new(null, null, "-123");
    }

    [TestMethod]
    public void CheckEqualsForOneObjectPositive()
    {
        Teacher teacher = new(null, null, "123");

        Assert.IsTrue(teacher.Equals(teacher));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithTheSameTaxIdPositive()
    {
        Teacher teacher = new(null, null, "123");
        SupportStaff supportStaff = new(null, null, "123");

        Assert.IsTrue(teacher.Equals(supportStaff));
    }

    [TestMethod]
    public void CheckEqualsForObjectAndNullPositive()
    {
        Teacher teacher = new(null, null, "123");

        Assert.IsFalse(teacher.Equals(null));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithDifferentTaxIdPositive()
    {
        Teacher teacher = new(null, null, "121");
        SupportStaff supportStaff = new(null, null, "123");

        Assert.IsFalse(teacher.Equals(supportStaff));
    }

    [TestMethod]
    public void CheckGetHashCodeForEqualObjectsPositive()
    {
        Teacher teacher = new(null, null, "123");
        SupportStaff supportStaff = new(null, null, "123");

        Assert.IsTrue(teacher.Equals(supportStaff));
        Assert.AreEqual(teacher.GetHashCode(), supportStaff.GetHashCode());
    }

    [TestMethod]
    public void CheckToStringPositive()
    {
        Person teacher = new("Freddy", "Krueger", null);
        Teacher teacherFull = new(null, teacher, "001");

        Assert.AreEqual(teacherFull.ToString(), "Freddy Krueger 001");
    }

    [TestMethod]
    public void CheckCompareToForObjectWithTheSameNameLengthsPositive()
    {
        Person person1 = new("Bibba", "Kuka", null);
        Person person2 = new("Bobba", "Grog", null);

        Teacher teacher1 = new(null, person1, "001");
        Teacher teacher2 = new(null, person2, "002");

        Assert.AreEqual(teacher1.CompareTo(teacher2), 0);
    }

    [TestMethod]
    public void CheckCompareToForObjectWithTheDifferentNameLengthsPositive()
    {
        Person person1 = new("Bibba", "Kukaracha", null);
        Person person2 = new("Bobba", "Grog", null);

        Teacher teacher1 = new(null, person1, "001");
        Teacher teacher2 = new(null, person2, "002");

        Assert.AreEqual(teacher1.CompareTo(teacher2), -1);
        Assert.AreEqual(teacher2.CompareTo(teacher1), 1);
    }
}