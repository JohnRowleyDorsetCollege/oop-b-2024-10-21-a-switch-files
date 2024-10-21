using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_b_2024_10_21_a_switch.Models
{
    public static class FileProgramDriver
    {
     
        public static void CreateEmptyFile()
        {

            Console.WriteLine("Creating a text file");
            string pathName = "../../../documents/quotes.txt";

            FileStream fs = File.Create(pathName);

            if (File.Exists(pathName))
            {
                Console.WriteLine("File is created");
            } else
            {
                Console.WriteLine("File is note created");
            }
        }
        public static void CreateTextFile()
        {

            Console.WriteLine("Creating a text file");
            string pathName = "../../../documents/helloworld.txt";

            File.WriteAllText(pathName, "Hello World");
        }

        public static void ReadTextFile()
        {

            Console.WriteLine("reading a text file");
            string pathName = "../../../documents/helloworld.txt";

            string readText = File.ReadAllText(pathName);

            Console.WriteLine(readText);
        }

    }
}
