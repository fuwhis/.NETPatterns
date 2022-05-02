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
            // Create ConcreteComponent & two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA cd_1 = new ConcreteDecoratorA();
            ConcreteDecoratorB cd_2 = new ConcreteDecoratorB();

            // Links decorators
            cd_1.SetComponent(c);
            cd_2.SetComponent(cd_1);

            cd_2.Operation();
            // Wait for user
            Console.ReadKey();
            #endregion
        }
    }
}
