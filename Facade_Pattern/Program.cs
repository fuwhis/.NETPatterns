using Facade_Pattern.RealWorld;
using Facade_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Facade Design Pattern
            /// </summary>
            #region Structual Code
            Console.WriteLine("****Structural Code Style****\n");
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            Console.WriteLine("\n");
            #endregion

            #region Real-world Code
            Console.WriteLine("****Real-world Code Style****\n");
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            #endregion
        }
    }
}
