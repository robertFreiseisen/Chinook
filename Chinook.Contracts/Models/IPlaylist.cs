using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IPlaylist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
    }
}
