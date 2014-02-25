﻿using System.Collections.Generic;

namespace Espera.Network
{
    public class NetworkPlaylist
    {
        public int? CurrentIndex { get; set; }

        public string Name { get; set; }

        public int? RemainingVotes { get; set; }

        public IReadOnlyList<NetworkSong> Songs { get; set; }
    }
}