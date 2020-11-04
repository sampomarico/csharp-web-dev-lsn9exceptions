using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Y is equal to zero.");
            }
            double result = x / y;
            return result;

        }

        static int CheckFileExtension(string fileName)
        {
            int studentPoints;
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("File name is null/non-existent.");
            }
            else if (fileName.EndsWith(".cs"))
            {
                studentPoints = 1;
            }
            else
            {
                studentPoints = 0;
            }
            return studentPoints;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(3, 0);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            
                foreach(KeyValuePair<string, string> student in students)
                {
                    try
                    {
                        Console.WriteLine(CheckFileExtension(student.Value));
                    }
                    catch(ArgumentNullException e)
                    {
                        Console.WriteLine("Filename is null/non-existant.");
                    }
                }
        }
    }
}
