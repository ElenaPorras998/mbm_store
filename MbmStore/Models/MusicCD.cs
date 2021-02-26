using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD: Product
    {
        public List<Track> Tracks { get; } = new List<Track>();
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public TimeSpan PlayingTime
        {
            get
            {
                TimeSpan pt = new TimeSpan();
                foreach (Track track in Tracks)
                {
                    pt = pt.Add(track.Length);
                }
                return pt;
            }
        }

        public MusicCD() {}
        public MusicCD(string artist, string title, decimal price, short released):base(title, price)
        {
            Artist = artist;
            Released = released;
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
    }
}
