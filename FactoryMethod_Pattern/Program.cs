using FactoryMethod_Pattern.ConcreteCreator;
using FactoryMethod_Pattern.RealWorld;
using FactoryMethod_Pattern.RealWorld.ConcreteDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            // An array of creators
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            // Iterate over creators and create products
            foreach(Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
            #endregion
            Console.WriteLine("\n--------------------------------\n");
            #region Real-world Code
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Display document pages
            foreach(Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach(Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            #endregion
        }
    }
}
