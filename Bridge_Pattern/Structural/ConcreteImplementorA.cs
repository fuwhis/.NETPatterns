using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.Structural
{
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    public class ConcreteImplementorA: Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
