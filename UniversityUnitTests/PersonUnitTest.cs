using excersise6;

namespace UniversityUnitTests;

[TestClass]
public class PersonUnitTest
{

    [TestMethod]
    public void CheckSetFirstNamePositive()
    {
        Person person = new();
        person.FirstName = "Vasia";

        Assert.AreEqual("Vasia", person.FirstName);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "A last name and first name length of more than 15 characters")]
    public void CheckSetTooLongFirstNameNegative()
    {
        Person person = new();
        person.FirstName = "Asdfghjklqwertyui";
    }

    [TestMethod]
    public void CheckSetLastNamePositive()
    {
        Person person = new();
        person.LastName = "Pupkin";

        Assert.AreEqual("Pupkin", person.LastName);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "A last name and first name length of more than 15 characters")]
    public void CheckSetTooLongLastNameNegative()
    {
        Person person = new();
        person.LastName = "Asdfghjklqwertyui";
    }

    [TestMethod]
    public void CheckConstructorPositive()
    {
        Person person = new("Vasia", "Pupkin", null);

        Assert.AreEqual("Vasia", person.FirstName);
        Assert.AreEqual("Pupkin", person.LastName);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "A last name and first name length of more than 15 characters")]
    public void CheckSetTooLongFirstAndLastNameNegative()
    {
        Person person = new("Asdfghjklqwertyui", "Asdfghjklqwertyui", null);
    }

    [TestMethod]
    public void CheckEqualsForOneObjectPositive()
    {
        Person person = new("Vasia", "Pupkin", null);

        Assert.IsTrue(person.Equals(person));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithTheSameNamePositive()
    {
        Person person1 = new("Vasia", "Pupkin", "Address1");
        Person person2 = new("Vasia", "Pupkin", "Address2");

        Assert.IsTrue(person1.Equals(person2));
    }

    [TestMethod]
    public void CheckEqualsForObjectAndNullPositive()
    {
        Person person = new("Vasia", "Pupkin", null);

        Assert.IsFalse(person.Equals(null));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithDifferentNamesPositive()
    {
        Person person1 = new("Vasia", "Pupkin", "Address");
        Person person2 = new("Vika", "Pupkina", "Address");

        Assert.IsFalse(person1.Equals(person2));
    }

    [TestMethod]
    public void CheckGetHashCodeForEqualObjectsPositive()
    {
        Person person1 = new("Vasia", "Pupkin", "Address1");
        Person person2 = new("Vasia", "Pupkin", "Address2");

        Assert.IsTrue(person1.Equals(person2));
        Assert.AreEqual(person1.GetHashCode(), person2.GetHashCode());
    }

    [TestMethod]
    public void CheckGetFirstAndLastNameLengthPositive() 
    {
        Person person = new("Vasia", "Pupkin", null);

        Assert.AreEqual(person.GetFirstAndLastNameLength(), 11);
    }
}