using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        // Fields
        private DateTime birthday;

        // Properties
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public List<string> PhoneNumbers { get; } = new List<string>();
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                int ca = CalculateAge(value);

                if (ca > 120 || ca < 0)
                {
                    throw new Exception("Age not accepted");
                } else
                {
                    birthday = value;
                }
            }

        }
        public int Age
        {
            get
            {
                return CalculateAge(birthday);
            }
        }

        public List<Invoice> Invoices { get; set; }


        // Constructors
        public Customer() { }

        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
        }

        // Methods
        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

        private int CalculateAge(DateTime bd)
        {
            DateTime now = DateTime.Now;
            int age;
            age = now.Year - bd.Year;

            if (now.Month < bd.Month || (now.Month == bd.Month && now.Day < bd.Day))
            {
                age--;
            }

            return age;
        }
    }
}
