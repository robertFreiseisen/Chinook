using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface ICustomer
    {
        public string Adress { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name => $"{LastName} {FirstName}";
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public int SupportRepId { get; set; }
    }
}
