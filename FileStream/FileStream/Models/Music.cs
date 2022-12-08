using FileStream.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Models
{
    internal class Music
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public int TimeWithSecond { get; set; }
        public Music()
        {
            Id = Guid.NewGuid();
        }
    }
}
