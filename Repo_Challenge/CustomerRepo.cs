using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Challenge
{
    public class CustomerRepo
    {
        private readonly List<Customer> _customers;
        // CRUD

        public void AddCustomer(string lastName, DateTime birthDate)
        {
            _customers.Add(new Customer(lastName, birthDate));
        }
        // This is better, because the fewer places you have to change your code to add a feature, the better. E.g. if we added a FirstName property, we wouldn't have to change the second method here
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public Customer GetCustomerById(int id)
        {
            foreach (Customer customer in _customers)
            {
                if (customer.CustomerId == id)
                {
                    return customer;
                }
            }
            // OR throw an Exception
            return null;

            // THIS CODE IS UNREACHABLE

            // LINQ
            // This one line does the exact same thing as the above tlines:
            return _customers.SingleOrDefault(customer => customer.CustomerId == id);

            // Another example - get all customers over 40
            _customers.Where(customer => customer.Age >= 40);
        }
    }
}
