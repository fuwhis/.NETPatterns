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
            Console.WriteLine("****Structural Code Style****");
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            #endregion
        }
    }
}
