using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Chinook.Contracts.Models
{
    public interface IPlaylistTrack
    {
        public IPlaylist Playlist { get; set; }
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }

    }
}
