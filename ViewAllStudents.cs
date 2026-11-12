using System;

namespace Finals_ISPRGG1
{
    internal static class ViewAllStudents
    {
        public static void Run(List<Dictionary<string, string>> studentList)
        {
            Console.Clear();
            Console.WriteLine("View all Students.\n");

            if (studentList.Count == 0)
            {

                Console.WriteLine("No Student records found.");
            }
            else
            {

                foreach (Dictionary<string, string> student in studentList)
                {
                    Console.WriteLine(
                        student["lastName"] + " " +
                        student["firstName"] + " " +
                        student["middleName"] + " " +
                        student["ID"]
                    );

                    Console.WriteLine("--------------------------------");
                }

                Console.WriteLine("Total Students: " + studentList.Count);
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}