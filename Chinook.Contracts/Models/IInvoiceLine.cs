using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IInvoiceLine
    {
        public IInvoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public int InvoiceLineId { get; set; }
        public int Quantity { get; set; }
        public int TrackId { get; set; }
        public double UnitPrice { get; set; }
    }
}
