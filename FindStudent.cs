using System;

namespace Finals_ISPRGG1;

public class FindStudent
{
    public static void Run(List<Dictionary<string, string>> students, Dictionary<string, string> studentID)
    {
        Console.WriteLine("Find a Student.\n");

        Console.Write("Enter the ID number of the student you want to find: ");
        string id = Console.ReadLine();

        if (studentID.ContainsKey(id))
        {
            string lastName = studentID[id];
            Console.WriteLine($"Student found: {lastName}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}
