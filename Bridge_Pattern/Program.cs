using Bridge_Pattern.RealWorld;
using Bridge_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Console.WriteLine("****Structural Code****");
            Abstraction ab = new RefinedAbstraction();

            //Set implementation and call 
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            // Change implemention and call 
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            Console.WriteLine("\n-------------------------\n");
            #endregion

            #region Real-world Code
            Console.WriteLine("***Realworld Code****");
            // Create RefinedAbstraction
            var customers = new Customers();
            // Set ConcreteImplementor
            customers.Data = new CustomersData("Chicago");
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            #endregion
        }
    }
}
