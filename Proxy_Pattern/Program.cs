using Proxy_Pattern.RealWorld;
using Proxy_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    /// <summary>
    /// Proxy Design Pattern
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Console.WriteLine("***Structural Code Output****\n");
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();
            #endregion
            Console.WriteLine("\n==========================\n");
            #region Real-world Code
            Console.WriteLine("***Real-world Code Output****\n");
            // Create math proxy
            MathProxy mathProxy = new MathProxy();
            // Do the math
            Console.WriteLine("4 + 2 = " + mathProxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + mathProxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + mathProxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + mathProxy.Div(4, 2));
            #endregion
        }
    }
}
