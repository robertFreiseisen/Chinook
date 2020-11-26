using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IMediaType
    {
        public int MediaTypeId { get; set; }
        public string Name { get; set; }
    }
}
