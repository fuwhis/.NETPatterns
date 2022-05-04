using Decorate_Pattern.RealWorld;
using Decorate_Pattern.Structural;
using System;

namespace Decorate_Pattern
{
    /// <summary>
    /// Decorator Design Pattern
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Console.WriteLine("****Structural Code Style****\n");
            // Create ConcreteComponent & two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA cd_1 = new ConcreteDecoratorA();
            ConcreteDecoratorB cd_2 = new ConcreteDecoratorB();

            // Links decorators
            cd_1.SetComponent(c);
            cd_2.SetComponent(cd_1);

            cd_2.Operation();
            #endregion

            #region Real-world Code
            Console.WriteLine("\n****Real-world Code Style****");
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.Display();

            #endregion
        }
    }
}
