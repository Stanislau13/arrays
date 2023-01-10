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

        Course course1 = new("Physic", "The course 'Physic' consists of sections 'Mechanics', 'Electricity and magnetism', 'Optics', 'Elements'");
        Course course2 = new("Chemistry", "The course 'Chemistry' gives the development of knowledge, skills and skills of students on the decision");

        SupportStaff Employee1 = new("Driver", person1, 00003);
        SupportStaff Employee2 = new("Guard", person2, 00004);
        SupportStaff Employee3 = new("Cleaner", person3, 00005);
        SupportStaff Employee4 = new("Cook", person4, 00006);
        SupportStaff Employee5 = new("Nurse", person5, 00007);
        Teacher Employee6 = new(course1, person6, 00001);
        DegreeTeacher Employee7 = new("Proffessor", "Docent", course2, person7, 00002);

        UniversityEmployee[] employees = { 
            Employee1,
            Employee2, 
            Employee3, 
            Employee4, 
            Employee5, 
            Employee6, 
            Employee7 
        };
        Console.WriteLine("***************** University Employees *****************");
        ShowInfoAboutEmploees(employees);
        Console.WriteLine();
        Console.WriteLine("*********************** Teachers ***********************");
        ShowInfoAboutEmploees(Array.FindAll(employees, employee => employee is Teacher));

        Room Room1 = new(Room.AssignmentType.Laboratory);
        Room Room2 = new(Room.AssignmentType.Lecture);
        Room Room3 = new(Room.AssignmentType.Auxiliary);
        Room Room4 = new(Room.AssignmentType.Seminar);
        
        Room[] Rooms1 = { Room1, Room2};
        Room[] Rooms2 = { Room3, Room4};

        Building Building1 = new("Studio 66 Patrick Terrace Callumfort", Rooms1);
        Building Building2 = new("Studio 68 Patrick Terrace Callumfort", Rooms2);

        Building[] Buildings = {Building1, Building2};
        University University = new(person8, Buildings, employees);
    }
    public static void ShowInfoAboutEmploees(UniversityEmployee[] employees)
    {
        foreach (UniversityEmployee employee in employees)
        {
            Console.WriteLine($"{employee.Person.FirstName} {employee.Person.LastName} {employee.GetOfficialDuties()}");
        }
    }
}