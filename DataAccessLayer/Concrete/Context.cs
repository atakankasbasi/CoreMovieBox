﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; database=CoreMoviesDB;integrated security=true;");
        }                                       //(localdb)\\MSSQLLocalDB
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<TvSerie> TvSeries { get; set; }

        public DbSet<Top10MovieList> Top10MovieLists { get; set; }
        public DbSet<Top10TvSerieList> Top10TvSerieLists { get; set; }

    }
}
