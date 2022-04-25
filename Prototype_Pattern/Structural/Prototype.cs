using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.Structural
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class Prototype
    {
        string id;

        // Constrcutor
        public Prototype(string id)
        {
            this.id = id;
        }

        // Gets id
        public string Id
        {
            get { return id;  }
        }

        public abstract Prototype Clone();
    }
}
