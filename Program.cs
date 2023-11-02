using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Willkommen zum Stundenplan-System");

        Console.WriteLine("Bitte geben Sie Ihren Vorname ein: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Bitte geben Sie Ihren Nachname ein: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Bitte geben Sie Ihre Klassenbezeichnung (IFZ-001 bis IFZ-004) ein: ");
        string className = Console.ReadLine();

        // Erstelle einen Stundenplan basierend auf der Klassenbezeichnung
        Dictionary<string, List<Course>> classSchedules = CreateClassSchedules();

        if (classSchedules.ContainsKey(className))
        {
            List<Course> studentSchedule = classSchedules[className];

            Console.WriteLine($"Hallo {firstName} {lastName}, hier ist Ihr Stundenplan für die Klasse {className}:");
            DisplaySchedule(studentSchedule);
        }
        else
        {
            Console.WriteLine("Klassenbezeichnung nicht erkannt. Bitte überprüfen Sie Ihre Eingabe.");
        }

        Console.ReadLine(); // Warten, damit die Konsolenanwendung nicht sofort beendet wird
    }

    static Dictionary<string, List<Course>> CreateClassSchedules()
    {
        var classSchedules = new Dictionary<string, List<Course>>();

        // Stundenplan für IFZ-001
        var ifz001Schedule = new List<Course>
        {
            new Course("Mathematik", "Montag", "9:00 - 10:30"),
            new Course("Informatik I", "Dienstag", "11:00 - 12:30"),
            new Course("Webentwicklung", "Mittwoch", "14:00 - 15:30"),
            new Course("Datenbanken", "Donnerstag", "9:00 - 10:30"),
            new Course("Programmierung II", "Freitag", "11:00 - 12:30")
        };

        // Stundenplan für IFZ-002
        var ifz002Schedule = new List<Course>
        {
            new Course("Informatik I", "Montag", "9:00 - 10:30"),
            new Course("Webentwicklung", "Dienstag", "11:00 - 12:30"),
            new Course("Datenbanken", "Mittwoch", "14:00 - 15:30"),
            new Course("Mathematik", "Donnerstag", "9:00 - 10:30"),
            new Course("Programmierung II", "Freitag", "11:00 - 12:30")
        };

        // Stundenplan für IFZ-003
        var ifz003Schedule = new List<Course>
        {
            new Course("Webentwicklung", "Montag", "9:00 - 10:30"),
            new Course("Datenbanken", "Dienstag", "11:00 - 12:30"),
            new Course("Mathematik", "Mittwoch", "14:00 - 15:30"),
            new Course("Programmierung II", "Donnerstag", "9:00 - 10:30"),
            new Course("Informatik I", "Freitag", "11:00 - 12:30")
        };

        // Stundenplan für IFZ-004
        var ifz004Schedule = new List<Course>
        {
            new Course("Datenbanken", "Montag", "9:00 - 10:30"),
            new Course("Mathematik", "Dienstag", "11:00 - 12:30"),
            new Course("Informatik I", "Mittwoch", "14:00 - 15:30"),
            new Course("Webentwicklung", "Donnerstag", "9:00 - 10:30"),
            new Course("Programmierung II", "Freitag", "11:00 - 12:30")
        };

        classSchedules.Add("IFZ-001", ifz001Schedule);
        classSchedules.Add("IFZ-002", ifz002Schedule);
        classSchedules.Add("IFZ-003", ifz003Schedule);
        classSchedules.Add("IFZ-004", ifz004Schedule);

        return classSchedules;
    }

    static void DisplaySchedule(List<Course> schedule)
    {
        foreach (var course in schedule)
        {
            Console.WriteLine($"{course.Name} - {course.Day} - {course.Time}");
        }
    }
}

class Course
{
    public string Name { get; }
    public string Day { get; }
    public string Time { get; }

    public Course(string name, string day, string time)
    {
        Name = name;
        Day = day;
        Time = time;
    }
}
