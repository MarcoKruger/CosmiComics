using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CosmiComics.Models
{
    public class ProductDBInitializer : DropCreateDatabaseAlways<ProductDBContext>
    {
        protected override void Seed(ProductDBContext context)
        {
            // Books
            context.Books.Add(new Book
            {
                Name = "Seven seas",
                Description = "Story about dragons",
                Image = "",
                Price = 320
            });
            context.Books.Add(new Book
            {

            });
            context.Books.Add(new Book
            {

            });
            context.Books.Add(new Book
            {

            });
            context.Books.Add(new Book
            {

            });
            context.Books.Add(new Book
            {

            });
            // Movies
            context.Movies.Add(new Movie
            {

            });
            context.Movies.Add(new Movie
            {

            });
            context.Movies.Add(new Movie
            {

            });
            context.Movies.Add(new Movie
            {

            });
            context.Movies.Add(new Movie
            {

            });
            // Music
            context.Music.Add(new Music
            {

            });
            context.Music.Add(new Music
            {

            });
            context.Music.Add(new Music
            {

            });
            context.Music.Add(new Music
            {

            });
            context.Music.Add(new Music
            {

            });
            base.Seed(context);
        }
    }
}