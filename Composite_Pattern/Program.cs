using Composite_Pattern.RealWorld;
using Composite_Pattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    /// <summary>
    /// Composite Design Pattern
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            #region Structural Code
            Console.WriteLine("****Structural Code****");
            // Create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            //Recursive display tree
            root.Display(1);
            #endregion
            Console.WriteLine("\n");
            #region Real-world Code
            Console.WriteLine("****Real-world Code****");
            // Create a tree structure 
            CompositeElement compTree = new CompositeElement("Picture");
            compTree.Add(new PrimitiveElement("Red Line"));
            compTree.Add(new PrimitiveElement("Blue Circle"));
            compTree.Add(new PrimitiveElement("Green Box"));
            // Create a branch
            CompositeElement compBranch = new CompositeElement("Two Circles");
            compBranch.Add(new PrimitiveElement("Black Circle"));
            compBranch.Add(new PrimitiveElement("White Circle"));
            compTree.Add(compBranch);
            // Add and remove a PrimitiveElement
            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            compTree.Add(pe);
            compTree.Remove(pe);
            // Recursively display nodes
            compTree.Display(1);
            #endregion
        }
    }
}
