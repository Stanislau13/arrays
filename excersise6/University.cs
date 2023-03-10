namespace excersise6;
public class University
{
    public List<UniversityEmployee> UniversityEmployees { get; set; }
    public Person Rector { get; set; }
    public List<Building> Buildings { get; set; }

    public University(Person rector, List<Building> building, List<UniversityEmployee> employees)
    {
        Rector = rector;
        Buildings = building;
        UniversityEmployees = employees;
    }
        public override bool Equals(Object other)
    {
        if (other == null || !GetType().Equals(other.GetType()))
        {
            return false;
        }
        return this == other || Rector.Equals(((University)other).Rector);
    }

    public override int GetHashCode()
    {
        return Rector.GetHashCode();
    }

    public bool AddEmployee(UniversityEmployee newEmployee)
    {
        foreach (UniversityEmployee employee in UniversityEmployees)
        {
            if (employee.Equals(newEmployee))
            {
                return false;
            }
        }
        UniversityEmployees.Add(newEmployee);
        return true;
    }

    public bool AddBuilding(Building newBuilding)
    {
        foreach (Building building in Buildings)
        {
            if (building.Equals(newBuilding))
            {
                return false;
            }
        }
        Buildings.Add(newBuilding);
        return true;
    }
}
