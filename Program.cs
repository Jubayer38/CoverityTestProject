using System;

class Program
{
    static void Main(string[] args)
    {
        string studentName = null; // CWE-476: NULL Pointer Dereference
        Console.WriteLine($"Student Name Length: {studentName.Length}"); // 🔥 NullReferenceException

        int[] grades = new int[5];
        grades[5] = 100; // CWE-119: Improper Restriction of Operations within the Bounds of a Memory Buffer (Array Index Out of Bounds)

        string[] courseNames = new string[5];
        Console.WriteLine(courseNames[0].ToUpper()); // CWE-476 again: Null pointer dereference

        int totalCredits = 0;
        int totalGradePoints = 0;

        // CWE-561: Dead Code
        if (false)
        {
            Console.WriteLine("This code is never executed.");
        }

        // CWE-563: Assignment to Variable without Use
        int unusedVar = 5;

        // CWE-190: Integer Overflow (if unchecked, but simulated here)
        int large = int.MaxValue;
        int result = large + 1;
        Console.WriteLine($"Overflow result: {result}");

        // CWE-398: Poor Code Quality (confusing output, unused logic)
        string course = "Math";
        if (course == "Math")
        {
            course = "Biology";
        }
        Console.WriteLine($"Course: {course}"); // Poor readability / design

        // CWE-259: Use of Hard-coded Password
        string password = "admin123";
        Console.WriteLine("Hardcoded password used: " + password);
    }
}
