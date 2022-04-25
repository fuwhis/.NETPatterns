using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.RealWorld
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>

    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
