using System;

class Program
{

    static void Main(string[] args)
    {
        char command;
        var studentList = new List<Dictionary<string, string>>();

        do
        {
            Console.WriteLine("CRUD Final Machine Project v1 (Quinones)");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("A-add a student              E-dit a student                 D-elete a student");
            Console.WriteLine("V-iew all student            F-ind a student");
            Console.WriteLine("L-oad data from file         S-ave data to file");
            Console.WriteLine("Q-uit the program");
            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.Write("Command: ");
            command = Console.ReadLine()[0];
            Console.Clear();

            switch (char.ToUpper(command))
            {
                case 'A':
                    Dictionary<string, string> student = new Dictionary<string, string>();
                    AddStudent.Run(student);
                    studentList.Add(student);
                    break;

                case 'E':

                    break;

                case 'V':
                    //ViewAll.run();
                    Console.WriteLine("View all students.\n");
                    Console.WriteLine(string.Join("\n", studentList[0]["lastName"] + " " + studentList[0]["firstName"] + " " + studentList[0]["middleName"] + "\n" + studentList[0]["id"]));
                    Console.ReadKey();
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
                    break;
            }

        } while (char.ToUpper(command) != 'Q');

    }
}
