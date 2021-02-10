using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Challenge
{
    public class Customer
    {
        public int CustomerId { get; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - BirthDate;
                return (int) Math.Floor(ageSpan.TotalDays / 365.24);
            }
        }
        public DateTime EnrollmentDate { get; }
        public int YearsWithCompany
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - EnrollmentDate;
                return (int) Math.Floor(ageSpan.TotalDays / 365.24);
            }
        }

        public Customer(string lastName, DateTime birthDate)
        {
            Random random = new Random();
            LastName = lastName;
            BirthDate = birthDate;
            EnrollmentDate = DateTime.Now;
            // In real life I would want to make sure this is unique
            CustomerId = random.Next(0, 999999999);
        }

        public string SendThankYouMessage()
        {
            if (YearsWithCompany >=1 && YearsWithCompany <=5)
            {
                return "Thank you for being loyal to this company!";
            } else if (YearsWithCompany > 5)
            {
                return "Thank you for being a Gold Member!";
            }
            return "Please stick around";
        }
    }
}
