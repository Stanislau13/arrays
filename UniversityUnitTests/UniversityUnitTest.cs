using Microsoft.VisualStudio.TestTools.UnitTesting;
using excersise6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTests;

[TestClass()]
public class UniversityUnitTest
{
    [TestMethod]
    public void CheckEqualsForOneObjectPositive()
    {
        Person rector = new("Neil", "Tyson", null);
        University university = new(rector, null, null);

        Assert.IsTrue(university.Equals(university));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithTheSameRectorPositive()
    {
        Person rector = new("Neil", "Tyson", null);
        University university1 = new(rector, null, null);
        University university2 = new(rector, null, null);

        Assert.IsTrue(university1.Equals(university2));
    }

    [TestMethod]
    public void CheckEqualsForObjectAndNullPositive()
    {
        Person rector = new("Neil", "Tyson", null);
        University university = new(rector, null, null);

        Assert.IsFalse(university.Equals(null));
    }

    [TestMethod]
    public void CheckEqualsForDifferentObjectsWithDifferentRectorsPositive()
    {
        Person rector1 = new("Neil", "Tyson", null);
        Person rector2 = new("Lawrence", "Krauss", null);

        University university1 = new(rector1, null, null);
        University university2 = new(rector2, null, null);

        Assert.IsFalse(university1.Equals(university2));
    }

    [TestMethod]
    public void CheckGetHashCodeForEqualObjectsPositive()
    {
        Person rector = new("Neil", "Tyson", null);
        University university1 = new(rector, null, null);
        University university2 = new(rector, null, null);

        Assert.IsTrue(university1.Equals(university2));
        Assert.AreEqual(university1.GetHashCode(), university2.GetHashCode());
    }

    [TestMethod]
    public void CheckAddEmployeeWithAlreadyAddedEmployeePositive()
    {
        Teacher teacher = new(null, null, "001");
        var employees = new List<UniversityEmployee> { teacher };
        University university = new(null, null, employees);

        Assert.IsFalse(university.AddEmployee(teacher));
        Assert.AreEqual(university.UniversityEmployees.Count, 1);
    }

    [TestMethod]
    public void CheckAddEmployeeWithNewEmployeePositive()
    {
        Teacher teacher1 = new(null, null, "001");
        Teacher teacher2 = new(null, null, "002");
        var employees = new List<UniversityEmployee> { teacher1 };
        University university = new(null, null, employees);

        Assert.IsTrue(university.AddEmployee(teacher2));
        Assert.AreEqual(university.UniversityEmployees.Count, 2);
        Assert.IsTrue(university.UniversityEmployees.Contains(teacher2));
    }

    [TestMethod]
    public void CheckAddBuildingWithAlreadyAddedBuildingPositive()
    {
        Building building = new("Address", null);
        var buildings = new List<Building> { building };
        University university = new(null, buildings, null);

        Assert.IsFalse(university.AddBuilding(building));
        Assert.AreEqual(university.Buildings.Count, 1);
    }

    [TestMethod]
    public void CheckAddBuildingWithNewBuildingPositive()
    {
        Building building1 = new("Address1", null);
        Building building2 = new("Address2", null);
        var buildings = new List<Building> { building1 };
        University university = new(null, buildings, null);

        Assert.IsTrue(university.AddBuilding(building2));
        Assert.AreEqual(university.Buildings.Count, 2);
        Assert.IsTrue(university.Buildings.Contains(building2));
    }
}
