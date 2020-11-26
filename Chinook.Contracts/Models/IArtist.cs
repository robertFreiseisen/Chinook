using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IArtist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
