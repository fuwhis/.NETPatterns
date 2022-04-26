using Adapter_Pattern.RealWorld;
using Adapter_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    /// <summary>
    /// Adapter Design Pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            #endregion

            #region Real-world Code
            // Non-adapted chemical compound
            Compound unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            #endregion
        }
    }
}
