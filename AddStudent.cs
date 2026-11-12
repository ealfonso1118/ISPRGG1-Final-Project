using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals_ISPRGG1 {

    internal static class AddStudent {

        public static void Run(List<Dictionary<string, string>> students) {

            Console.WriteLine("Add a Studendt.\n");

            string lastName;
            while (true) {

                Console.Write("Last name: ");
                lastName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(lastName) && lastName.Length <= 20) {

                    break;
                }

                Console.WriteLine("Maximum of 20 characters only. Try again.");
            }

            string firstName;
            while (true) {

                Console.Write("First name: ");
                firstName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(firstName) && firstName.Length <= 20) {

                    break;
                }

                Console.WriteLine("Maximum of 20 characters only. Try again.");
            }

            string middleName;
            while (true) {

                Console.Write("Middle name: ");
                middleName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(middleName) && middleName.Length <= 20) {

                    break;
                }

                Console.WriteLine("Maximum of 20 characters only. Try again.");
            }


            string id;
            bool validID;

            while (true) {

                Console.Write("ID number: ");
                id = Console.ReadLine();

                validID = true;

                if (string.IsNullOrWhiteSpace(id) || id.Length != 8) {
                    validID = false;
                }
                else {

                    for (int i = 0; i < id.Length; i++) {

                        if (id[i] < '0' || id[i] > '9') {

                            validID = false;
                            break;
                        }
                    }
                }

                if (validID) {

                    break;
                }

                Console.WriteLine("ID must contain exactly 8 digits. Numbers only. Try again.");
            }

            Dictionary<string, string> student = new Dictionary<string, string>();

            student["lastName"] = lastName;
            student["firstName"] = firstName;
            student["middleName"] = middleName;
            student["ID"] = id;

            students.Add(student);

            Console.WriteLine("\nStudent information successfully added!");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}