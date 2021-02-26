using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie: Product
    {
        public string Director { get; set; }
        public short Released { get; set; }

        // constructors
        public Movie() { }

        public Movie(string title, decimal price): base(title, price) {}

        public Movie(string title, decimal price, string imageFileName, string director): base(title, price, imageFileName)
        {
            Director = director;
        }
    }
}