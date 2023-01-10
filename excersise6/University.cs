namespace excersise6;

internal class University
{
    public UniversityEmployee[] UniversityEmployees { get; set; }
    public Person Rector { get; set; }
    public Building[] Buildings { get; set; }
    public University() { }
    public University(Person rector, Building[] building, UniversityEmployee[] employee)
    {
        Rector = rector;
        Buildings = building;
        UniversityEmployees = employee;
    }
}
