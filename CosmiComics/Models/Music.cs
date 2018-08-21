using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmiComics.Models
{
    public class Music
    {
        public virtual int MusicId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Image { get; set; }
        public virtual decimal Price { get; set; }
    }
}