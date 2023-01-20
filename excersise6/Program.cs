using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Collections.Specialized.BitVector32;

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
        Person person7 = new("Christopher", "Leonard", "171 Murray Shoals Walkerstad");
        Person person8 = new("Alfred", "Dixon", "Studio 19 Cliff Shannonshire");
        Person person9 = new("Leslie", "Dixon", "171 Murray Shannonshire");

        Course course1 = new("Physic", "The course 'Physic' consists of sections 'Mechanics', 'Electricity and magnetism', 'Optics', 'Elements'");
        Course course2 = new("Chemistry", "The course 'Chemistry' gives the development of knowledge, skills and skills of students on the decision");
        Course course3 = new("Physic", "......");

        SupportStaff Employee1 = new("Driver", person1, "00003");
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
        ShowInfoAboutEmploees(employees);
        Console.WriteLine();
        Console.WriteLine("*********************** Teachers ***********************");
        ShowInfoAboutEmploees(employees.FindAll(employee => employee is Teacher));

        //task 5.1
        Console.WriteLine("********************************************************");
        var newEmployee = employees.Where(employee => employee.Person.LastName.Contains("W")).OrderBy(employee => employee.TaxID).Select(employee => employee.ToString());
        Console.WriteLine(string.Join(Environment.NewLine, newEmployee));
        Console.WriteLine("********************************************************");
        //task 5.2
        var newTeacher = employees.Where(employee => (employee is Teacher) && ((Teacher)employee).Course.Name.Equals("Physic")).Select(employee => employee.ToString());
        Console.WriteLine(string.Join(Environment.NewLine, newTeacher));
        Console.WriteLine("********************************************************");
        //task 5.3
        var newTaxSupport = employees.Select(employee => $"{employee.TaxID} {employee.GetOfficialDuties()}");
        Console.WriteLine(string.Join(Environment.NewLine, newTaxSupport));
        Console.WriteLine("********************************************************");
        //task 5.6
        var group = employees.GroupBy(employee => employee.Person.LastName).OrderByDescending(group => group.Count()).First();
        Console.WriteLine($"{group.Key} {group.Count()}");
        Console.WriteLine("********************************************************");

        Room Room1 = new(Room.AssignmentType.Laboratory, 1);
        Room Room2 = new(Room.AssignmentType.Lecture, 2);
        Room Room3 = new(Room.AssignmentType.Auxiliary, 1);
        Room Room4 = new(Room.AssignmentType.Seminar, 2);
        Room Room5 = new(Room.AssignmentType.Auxiliary, 3);

        List<Room> Rooms1 = new (){ Room1, Room2};
        List<Room> Rooms2 = new (){ Room3, Room4, Room5};

        Building Building1 = new("Studio 66 Patrick Terrace Callumfort", Rooms1);
        Building Building2 = new("Studio 68 Patrick Terrace Callumfort", Rooms2);

        List <Building> Buildings = new (){Building1, Building2};
        University University = new(person8, Buildings, employees);

        bool EmployeeAdd = University.AddEmployee(Employee7);
        bool RoomAdd = Building1.AddRoom(Room2);

        //task 5.4
        var buildingsWithRoom = Buildings.Where(building => building.Rooms.Exists(room => room.Number == 1)).Select(building => building.Address);
        Console.WriteLine(string.Join(Environment.NewLine, buildingsWithRoom));
        Console.WriteLine("********************************************************");
        //task 5.5
        Building buildingsWithMaxNumberOfRooms = Buildings.OrderByDescending(building => building.Rooms.Count).First();
        Console.WriteLine(buildingsWithMaxNumberOfRooms.Address);
        Console.WriteLine("********************************************************");
    }
    public static void ShowInfoAboutEmploees(List<UniversityEmployee> employees)
    {
        foreach (UniversityEmployee employee in employees)
        {
            Console.WriteLine($"{employee.Person.FirstName} {employee.Person.LastName} {employee.GetOfficialDuties()}");
        }
    }
}