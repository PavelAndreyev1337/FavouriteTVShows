using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FavouriteTVShows.Models;

namespace FavouriteTVShows.Data
{
    public class TvShowsContext : DbContext
    {
        public TvShowsContext (DbContextOptions<TvShowsContext> options)
            : base(options)
        {
        }

        public DbSet<FavouriteTVShows.Models.TvShow> TvShow { get; set; }
    }
}
