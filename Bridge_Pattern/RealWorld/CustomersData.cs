using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.RealWorld
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class CustomersData : DataObject
    {
        private readonly List<string> customers = new List<string>();
        private int _current = 0;
        private string _city;

        public CustomersData(string city)
        {
            this._city = city;
            // Loaded from a database 
            customers.Add("Jim Jones");
            customers.Add("Samual Jackson");
            customers.Add("Allen Good");
            customers.Add("Ann Stills");
            customers.Add("Lisa Giolani");
        }
        public override void NextRecord()
        {
            if(_current <= customers.Count - 1)
            {
                _current++;
            }
        }
        public override void PriorRecord()
        {
            if(_current > 0)
            {
                _current--;
            }
        }
        public override void AddRecord(string _customer)
        {
            customers.Add(_customer);
        }
        public override void DeleteRecord(string _customer)
        {
            customers.Remove(_customer);
        }
        public override string GetCurrentRecord()
        {
            return customers[_current];
        }
        public override void ShowRecord()
        {
            Console.WriteLine(customers[_current]);
        }
        public override void ShowAllRecords()
        {
            Console.WriteLine("Customer City: " + _city);

            foreach(string customerItem in customers)
            {
                Console.WriteLine(" " + customerItem);
            }
        }
    }
}
