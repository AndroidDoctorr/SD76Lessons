using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Currency
{
    public class Penny : ICurrency
    {
        public string Name => "Penny";
        public decimal Value => 0.01m;
    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";
        public decimal Value => 0.1m;
    }
    public class Dollar : ICurrency
    {
        public string Name => "Dollar";
        public decimal Value => 1.0m;
    }

    public class ElectronicPayment : ICurrency
    {
        public string Name
        {
            get {
                // if () blah blah etc
                return "Electronic Payment";
            }
        }

        public decimal Value { get; }

        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
    }

    public class Monkey : ICurrency
    {
        public string Name => "Monkey!!";
        public decimal Value => 0m;
        public void Shout()
        {
            Console.WriteLine("EEK EEK!");
        }
    }
}
