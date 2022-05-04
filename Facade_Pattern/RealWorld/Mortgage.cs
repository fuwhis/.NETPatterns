using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.RealWorld
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);
            bool eligible = true;

            // Check credit worthyness of application
            if(!bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if(!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if(!credit.HasGoodCredit(customer))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
