using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Singleton
    {
        static Singleton instance;

        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization
            // Note: this is not thread safe
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
