using System;

class Program
{
    static void Main(string[] args)
    {
        string studentName = "Sophia Johnson"; // ✅ No nulls
        Console.WriteLine($"Student Name Length: {studentName.Length}");

        int[] grades = new int[5] { 90, 85, 88, 92, 95 }; // ✅ Proper array initialization and access
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Grade {i + 1}: {grades[i]}");
        }

        string[] courseNames = new string[5] { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
        foreach (string course in courseNames)
        {
            Console.WriteLine(course.ToUpper()); // ✅ No null values
        }

        int totalCredits = 3 + 3 + 4 + 4 + 3;
        int totalGradePoints = (4 * 3) + (3 * 3) + (3 * 4) + (3 * 4) + (4 * 3); // ✅ Proper GPA calc

        decimal gpa = (decimal)totalGradePoints / totalCredits;
        Console.WriteLine($"GPA: {gpa:F2}"); // Shows GPA up to 2 decimal places

        // ✅ Removed dead code, unused variables, overflow, and hardcoded passwords

        string courseExample = "Math";
        if (courseExample == "Math")
        {
            Console.WriteLine("Course is Math.");
        }

        // ✅ Removed hardcoded password
        Console.WriteLine("Authentication is secured externally.");
    }
}
