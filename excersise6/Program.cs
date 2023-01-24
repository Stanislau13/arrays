namespace excersise6;
internal class Program
{
    static void Main(string[] args)
    {
        Person person1 = new("Douglas", "Glenn", "593 Adams Coves Wardside");
        Person person2 = new("Robert", "Day", "Flat 18p Harris Roads Port Riley");
        Person person3 = new("Matthew", "Dixon", "68 Leah Corners West Kevinchester");
        Person person4 = new("Morgan", "Welch", "Studio 73j Patrick Terrace Callumfort");
        Person person5 = new("Alfred", "Melton", "Flat 50 Moore Common North Sasha");
        Person person6 = new("Leslie", "Warner", "9 Bruce Cliff Shannonshire");
        Person person7 = new("Christopher", "Le", "171 Murray Shoals Walkerstad");
        Person person8 = new("Alfred", "Dixon", "Studio 19 Cliff Shannonshire");
        Person person9 = new("Leslie", "Dixon", "171 Murray Shannonshire");

        Course course1 = new("Physic", "The course 'Physic' consists of sections 'Mechanics', 'Electricity and magnetism', 'Optics', 'Elements'");
        Course course2 = new("Chemistry", "The course 'Chemistry' gives the development of knowledge, skills and skills of students on the decision");
        Course course3 = new("Physic", "......");

        SupportStaff Employee1 = new("Driver", person1, "00001");
        SupportStaff Employee2 = new("Guard", person2, "00004");
        SupportStaff Employee3 = new("Cleaner", person3, "00005");
        SupportStaff Employee4 = new("Cook", person4, "00006");
        SupportStaff Employee5 = new("Nurse", person5, "00007");
        Teacher Employee6 = new(course1, person6, "00001");
        DegreeTeacher Employee7 = new("Proffessor", "Docent", course2, person7, "00002");
        DegreeTeacher Employee8 = new("Proffessor", "Docent", course3, person9, "00008");

        var employees = new List<UniversityEmployee>() 
        { 
            Employee1,
            Employee2,
            Employee3, 
            Employee4, 
            Employee5, 
            Employee6, 
            Employee7,
            Employee8
        };
        Console.WriteLine("***************** University Employees *****************");
        ShowInfoAboutEmploeesWithDuties(employees);
        Console.WriteLine();
        Console.WriteLine("*********************** Teachers ***********************");
        ShowInfoAboutEmploeesWithDuties(employees.FindAll(employee => employee is Teacher));

        //task 5.1
        Console.WriteLine("********************************************************");
        ShowInfoAboutEmploeesWithTaxId(employees
            .Where(employee => employee.Person.LastName.StartsWith("W"))
            .OrderBy(employee => employee.TaxId)
            .ToList());
        Console.WriteLine("********************************************************");

        //task 5.2
        ShowInfoAboutEmploeesWithTaxId(employees
            .Where(employee => (employee is Teacher) && ((Teacher)employee).Course.Name.Equals("Physic"))
            .ToList());
        Console.WriteLine("********************************************************");

        //task 5.3
        var newTaxSupport = employees
            .Select(employee => $"{employee.TaxId} {employee.GetOfficialDuties()}");
        Console.WriteLine(string.Join(Environment.NewLine, newTaxSupport));
        Console.WriteLine("********************************************************");

        //task 5.6
        var group = employees
            .GroupBy(employee => employee.Person.LastName)
            .MaxBy(group => group.Count());
        Console.WriteLine($"{group.Key} {group.Count()}");
        Console.WriteLine("********************************************************");

        Room Room1 = new(AssignmentType.Laboratory, 1);
        Room Room2 = new(AssignmentType.Lecture, 2);
        Room Room3 = new(AssignmentType.Auxiliary, 1);
        Room Room4 = new(AssignmentType.Seminar, 2);
        Room Room5 = new(AssignmentType.Auxiliary, 3);

        List<Room> Rooms1 = new(){ Room1, Room2};
        List<Room> Rooms2 = new(){ Room3, Room4, Room5};

        Building Building1 = new("Studio 66 Patrick Terrace Callumfort", Rooms1);
        Building Building2 = new("Studio 68 Patrick Terrace Callumfort", Rooms2);

        List <Building> Buildings = new(){Building1, Building2};
        University University = new(person8, Buildings, employees);

        bool EmployeeAdd = University.AddEmployee(Employee7);
        bool RoomAdd = Building1.AddRoom(Room2);

        //task 5.4
        var buildingsWithRoom = Buildings
            .Where(building => building.Rooms.Exists(room => room.Number == 1))
            .Select(building => building.Address);
        Console.WriteLine(string.Join(Environment.NewLine, buildingsWithRoom));
        Console.WriteLine("********************************************************");

        //task 5.5
        Building buildingsWithMaxNumberOfRooms = Buildings
            .MaxBy(building => building.Rooms.Count);
        Console.WriteLine(buildingsWithMaxNumberOfRooms.Address);
        Console.WriteLine("********************************************************");

        //task 6.1
        try
        {
            new SupportStaff("Driver", person1, "-1ddd11");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message + " oops..");
        }
        Console.WriteLine("********************************************************");

        //task 6.2
        try
        {
            new Person ("Douglas1233399999222", "Glenn12322121212131232123213", "593 Adams Coves Wardside"); ;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message + " oops..");
        }
        Console.WriteLine("********************************************************");

        //task 6.3 Sort()
        List<UniversityEmployee> employeeForSort = new(employees);
        employeeForSort.Sort();
        ShowInfoAboutEmploeesWithNameLength(employeeForSort);
        Console.WriteLine("********************************************************");

        //task 6.3 OrderBy
        ShowInfoAboutEmploeesWithNameLength(employees
            .OrderByDescending(x => x.Person.GetFirstAndLastNameLength())
            .ToList());
        Console.WriteLine("********************************************************");

        //task 6.3 Sort(IComparer)
        List<UniversityEmployee> employeeForSort2 = new(employees);
        Comparer<UniversityEmployee> universityEmployeeComparer = Comparer<UniversityEmployee>
            .Create((x, y) => y.Person.GetFirstAndLastNameLength()
            .CompareTo(x.Person.GetFirstAndLastNameLength()));
        employeeForSort2.Sort(universityEmployeeComparer);
        ShowInfoAboutEmploeesWithNameLength(employeeForSort2);
    }
    public static void ShowInfoAboutEmploeesWithDuties(List<UniversityEmployee> employees)
    {
        foreach (UniversityEmployee employee in employees)
        {
            Console.WriteLine($"{employee.Person.FirstName} {employee.Person.LastName} {employee.GetOfficialDuties()}");
        }
    }

    public static void ShowInfoAboutEmploeesWithTaxId(List<UniversityEmployee> employees)
    {
        foreach (UniversityEmployee employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }

    public static void ShowInfoAboutEmploeesWithNameLength(List<UniversityEmployee> employees)
    {
        foreach (UniversityEmployee employee in employees)
        {
            Console.WriteLine($"{employee.Person.FirstName} {employee.Person.LastName} {employee.Person.GetFirstAndLastNameLength()}");
        }
    }
}