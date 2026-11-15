using System;

using System;
using SRP.After;
using OCP.After;
using LSP.After;
using ISP.After;
using DIP.After;

namespace Solid;

public class SolidRunner
{
    public void Run()
    {
        Console.WriteLine("===== SOLID PRINCIPLES =====");

        // 1. SRP
        Console.WriteLine("\n--- SRP ---");
        var student = new Student();
        student.AddStudent();

        var grade = new GradeCalculator();
        grade.CalculateMarks();

        var report = new StudentReport();
        report.DisplayReport();

        // 2. OCP
        Console.WriteLine("\n--- OCP ---");
        var calculator = new DiscountCalculator();
        var discount = calculator.GetDiscount(new FestivalDiscount(), 1000);
        Console.WriteLine($"Discount: {discount}");

        // 3. LSP
        Console.WriteLine("\n--- LSP ---");
        var person = new Person();
        person.Runing();

        var Crow = new Crow();
        Crow.Fly();

        // 4. ISP
        Console.WriteLine("\n--- ISP ---");
        var human = new Humans();
        human.Read();
        human.Play();

        var animals = new Animals();
        animals.Play();

        // 5. DIP
        Console.WriteLine("\n--- DIP ---");
        var notification = new Notification(new SMS());
        notification.SendNotification();

        Console.WriteLine("\nAll examples completed!");
    }
}