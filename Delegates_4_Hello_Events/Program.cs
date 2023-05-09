// See https://aka.ms/new-console-template for more information
using Delegates_4_Hello_Events;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, College!");
var hist = new CollegeClass("History 101", 3);
var math = new CollegeClass("Calculus", 2);

//STEP 2 - Begin Listening to this event 
hist.EnrollmentFull += Hist_EnrollmentFull;


math.EnrollmentFull += Math_EnrollmentFull; // AYTO EINAI T
math.EnrollmentFull += MAth_EnrollmentFullDeyterosListener;
math.EnrollmentFull += MAth_EnrollmentFullGiannisImplementation;

void MAth_EnrollmentFullGiannisImplementation(object? sender, string e)
{
    Console.WriteLine();
    Console.WriteLine(e);
    Console.WriteLine();
    var whodunnit = (CollegeClass)sender;
    Console.WriteLine($"To mathima {whodunnit.Title} exei kapoio provlima");
    Console.WriteLine($"Oi max participants itan tosoi {whodunnit.MaxParticipants} Mipws na tous allaksw");

}

void Math_EnrollmentFull(object? sender, string e)
{
    Console.WriteLine("H lista twn mathimatikwn gemise...STELNW MAIL GRAMMATEIA");
}

void MAth_EnrollmentFullDeyterosListener(object? sender, string e)
{
    Console.WriteLine("H lista tis istorias gemise...STELNW SMS STON CEO");
}


void Hist_EnrollmentFull(object? sender, string e)
{
    Console.WriteLine("H lista tis istorias gemise");
}

hist.SignUpStudent("Kosmas Haritonidis").PrintToConsole();
hist.SignUpStudent("Panagiotis Kolovos").PrintToConsole();
hist.SignUpStudent("Vasileios Magkakis").PrintToConsole();
hist.SignUpStudent("Kallidonis Ioannis").PrintToConsole();

math.SignUpStudent("Styliani Papadopoulou").PrintToConsole();
math.SignUpStudent("Vasileios Magkakis").PrintToConsole();
math.SignUpStudent("Christos Koustas").PrintToConsole();
math.SignUpStudent("Georgios Ntomoras").PrintToConsole();



public class CollegeClass
{
    //STEP 1 Create the event
    public event EventHandler<string> EnrollmentFull;

    public string Title { get; private set; } = string.Empty;

    public int MaxParticipants { get; private set; }

    private List<string> EnrolledStuds = new List<string>();
    private List<string> WaitingList = new List<string>();

    public CollegeClass(string title, int maxParticipants)
    {
        Title = title;
        MaxParticipants = maxParticipants;
    }

    public string SignUpStudent(string student)
    {
        string output = string.Empty;
        if (EnrolledStuds.Count < MaxParticipants)
        {
            EnrolledStuds.Add(student);
            output = $"Student {student} has been added to {Title}";
            if (EnrolledStuds.Count == MaxParticipants)
            {
                //STEP 3 RAISE THE EVENT ---INVOCATION
                EnrollmentFull?.Invoke( this , $"Course Title {Title} is full");
            }
        }
        else
        {
            WaitingList.Add(student);
            output = $"Student {student} has been added to {Title} waiting list";
        }
        return output;
    }
}