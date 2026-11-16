using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{

    using Design_Pattern.BuilderPattern;
    using Design_Pattern.FactoryPattern;
    using Design_Pattern.FactoryPattern.FactoryPattern;
    using Design_Pattern.RepositoryPattern;
    using Design_Pattern.StratergyPattern;
    using System;


    public class PrincipleRunner
    {
        public void Run()
        {
            // 1. Strategy Pattern
            Console.WriteLine("=== Strategy Pattern ===");

            IGradeStrategy percentage = new PercentageGrade();
            GradeCalculator calculator1 = new GradeCalculator(percentage);
            calculator1.Calculate();

            IGradeStrategy passFail = new PassFailGrade();
            GradeCalculator calculator2 = new GradeCalculator(passFail);
            calculator2.Calculate();


            // 2. Repository Pattern
            Console.WriteLine("\n=== Repository Pattern ===");

            BookRepository repo = new BookRepository();

            repo.AddBook(new Book { Id = 1, Title = "C# Basics" });
            repo.AddBook(new Book { Id = 2, Title = "Python Basics" });

            repo.GetBooks();


            // 3. Factory Pattern
            Console.WriteLine("\n=== Factory Pattern ===");

            MessageFactory factory = new MessageFactory();

            IMessage email = factory.CreateMessage("Email");
            Notification emailNotification = new Notification(email);
            emailNotification.SendNotification();

            IMessage sms = factory.CreateMessage("SMS");
            Notification smsNotification = new Notification(sms);
            smsNotification.SendNotification();


            // 4. Builder Pattern
            Console.WriteLine("\n=== Builder Pattern ===");

            Student student = new StudentBuilder()
                .SetName("Joy Alex")
                .SetMaths(90)
                .SetScience(88)
                .SetSocial(80)
                .SetComputer(95)
                .Build();

            Console.WriteLine("Student: " + student.Name);
            Console.WriteLine("Maths: " + student.Maths);
            Console.WriteLine("Science: " + student.Science);
            Console.WriteLine("Social: " + student.Social);
            Console.WriteLine("Computer: " + student.Computer);
        }
    }
}


