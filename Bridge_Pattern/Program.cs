using Bridge_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Abstraction ab = new RefinedAbstraction();

            //Set implementation and call 
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            // Change implemention and call 
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            Console.WriteLine("\n");
            #endregion

            #region Real-world Code
            // Create RefinedAbstraction
            var customers = new Customers(); 
            #endregion
        }
    }
}
