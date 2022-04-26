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

            #endregion
        }
    }
}
