using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.Structural
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
