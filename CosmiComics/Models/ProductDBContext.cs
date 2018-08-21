using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CosmiComics.Models
{
    public class ProductDBContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
    }
}