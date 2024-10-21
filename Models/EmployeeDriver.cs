using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_b_2024_10_21_a_switch.Models
{
    public static class EmployeeDriver
    {

        public static void GenerateEmployees () {

            List<Employee> listOfEmployees = new EmployeeFaker().Generate(100);
            string pathName = "../../../documents/employees.txt";
            // string.join (convert list to a string and add new line)
            File.WriteAllText(pathName, string.Join($",\r\n",listOfEmployees));

        }

        public static void ReadEmployeeFile()
        {
            // use chat gpt to figure out out to read in the lines from
            // a csv file
            // then print each line but you must seperate the name and lastname
            // showing them as FN: FIRSTNAME : LN : LASTNAME 
            // Ryley | Wintheiser,
            // FN: Ryley : LN Wintheiser


            string pathName = "../../../documents/employees.txt";

            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(pathName);

            // Print each line individually
            foreach (string line in lines)
            {
                var splitName = line.Split('|');
                Console.WriteLine($"FN:{splitName[0]}LN:{splitName[1]}");
            }

        }

    }
}
