using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IInvoice
    {
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceDate { get; set; }
        public int InvoiceId { get; set; }
        public double Total { get; set; }
    }
}
