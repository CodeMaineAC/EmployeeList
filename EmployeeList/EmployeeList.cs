using System;
using System.Collections.Generic; //Needed for list creation

namespace EmployeeList
{
    /*
     * Emplyee List
     * 1/05/2021
     * Demonstration of how to import an array into a list and how to creat some basic methods
     */
    class EmployeeList
    {
        
        private static void Main(string[] args)
        {
            string[] employees = {"Jen", "Dave", "Lisa", "Lynn", "Joe", "Mike" }; //Creates and array
            List<string> empList = new List<string>(employees); //Creates alist of the array 'employees'
            empList.Sort();

            EmployeeList.PrintList(empList); //one way to call on a method but not needed for methods that are part of the same class as the program

            CapilizedPrint(empList);



        }

        //Method that prints a list and takes a list as an argument
        static void PrintList(List<string> list)
        {
            Console.WriteLine("Printing list of Employees\n");
            foreach (string name in list) Console.Write(" {0}", name);
        }

        // Prints out the list in all caps, takes a list as an argument and uses the method 'CapitilizeName()' to capitilize names for printing
        //In retropspect this incrediably inefficient as it requires the program to search for each item in the list.
        static void CapilizedPrint(List<string> list)
        {
            string i = "50";
            int ii;
            
            Console.WriteLine("\n PRINTING LIST OF EMPLOYEES");
            foreach (string name in list) Console.Write(" {0}", CapitilizeName(list, name));
        }
        //Capitlizes a given name in a list, needs a lsit and the name to search for
        static string CapitilizeName(List<string> list, string key)
        {
            string name = list[list.IndexOf(key)];
            return name.ToUpper();
        }
    }
    
}
