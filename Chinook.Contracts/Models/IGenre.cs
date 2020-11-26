using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IGenre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
