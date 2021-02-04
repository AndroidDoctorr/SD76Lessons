using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Currency
{
    // Dependency Injection - "interchangeable parts" code depends on an object being injected as a parameter from the outside
    public interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }
    }
}
