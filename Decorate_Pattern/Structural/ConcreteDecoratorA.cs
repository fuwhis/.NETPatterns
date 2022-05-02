using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate_Pattern.Structural
{
    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    public class ConcreteDecoratorA : Decorate
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorateA.Operation()");
        }
    }
}
