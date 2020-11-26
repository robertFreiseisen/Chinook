using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IAlbum
    {
        public int AlbumId { get; set; }
        public IArtist Artist { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
    }
}
