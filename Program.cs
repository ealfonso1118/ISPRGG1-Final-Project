using System;
using System.ComponentModel;

namespace Finals_ISPRGG1
{

    class Program
    {

        static void Main(string[] args)
        {


            char command;
            List<Dictionary<string, string>> studentList = new List<Dictionary<string, string>>();

            do
            {

                Console.WriteLine("CRUD Final Machine Project v1 (Quinones & Alfonso)");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("A-add a student              E-dit a student                 D-elete a student");
                Console.WriteLine("V-iew all student            F-ind a student");
                Console.WriteLine("L-oad data from file         S-ave data to file");
                Console.WriteLine("Q-uit the program");
                Console.WriteLine("---------------------------------------------------------------------------------");

                Console.Write("Command: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {

                    command = '\0';
                }
                else
                {

                    command = input[0];
                }
                Console.Clear();

                switch (char.ToUpper(command))
                {

                    case 'A':

                        AddStudent.Run(studentList);
                        break;

                    case 'E':

                        break;

                    case 'V':

                        ViewAllStudents.Run(studentList);
                        break;

                    case 'F':

                        break;

                    case 'L':

                        break;

                    case 'S':

                        break;

                    case 'D':

                        break;

                    case 'Q':

                        Console.WriteLine("Quit Proram!");
                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Invalid Input!");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }

            } while (char.ToUpper(command) != 'Q');

        }
    }
}