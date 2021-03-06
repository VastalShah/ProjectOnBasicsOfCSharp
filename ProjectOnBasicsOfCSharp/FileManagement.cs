using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectOnBasicsOfCSharp
{
    class FileManagement
    {
        public static void Do()
        {
            WriteStudentDetails();
            ReadStudentDetails();
        }
        private static void WriteStudentDetails()
        {
            string dir = Directory.GetCurrentDirectory();
            string path = dir + "\\studentData.txt";
            Console.WriteLine(path);
            if(File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("file Does Not Exist");
            }
            Console.WriteLine("Adding content in the file...");
            StreamWriter wrt = File.CreateText(path);
            wrt.WriteLine("Ram, 30, CSE");
            wrt.WriteLine("Sita, 25, ME");
            wrt.WriteLine("Shyam, 35, Civil");
            wrt.WriteLine("Geeta, 31, PE");
            wrt.Close();
            Console.WriteLine("Content has been added to the file.");
        }

        private static void ReadStudentDetails()
        {
            string dir = Directory.GetCurrentDirectory();
            string path = dir + "\\studentData.txt";
            Console.WriteLine("Reading File...");
            if (File.Exists(path))
            {
                Console.WriteLine("File Exist");
                var contents = File.ReadAllLines(path);
                foreach(var content in contents)
                {
                    string[] data = content.Split(", ");
                    string details = "Name: " + data[0] + ", Age: " + data[1] + ", Dept: " + data[2];
                    Console.WriteLine(details);
                }
            }
            else
            {
                Console.WriteLine("File Does not exist");
            }
        }
    }
}