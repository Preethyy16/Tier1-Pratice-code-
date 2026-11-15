using System;
namespace SRP.Before;
// Violates SRP: one class has 3 methods.
public class StudentManager
{
    public void AddStudent()
    {
        Console.WriteLine("Student details added");
    }
    public void CalculateMarks()
    {
        Console.WriteLine("Marks calculated");
    }
 public void DisplayReport()
    {
        Console.WriteLine("Student report displayed");
    }
}