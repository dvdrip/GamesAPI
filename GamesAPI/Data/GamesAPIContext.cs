using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesAPI.Model;

namespace GamesAPI.Data
{
    public class GamesAPIContext : DbContext
    {
        public GamesAPIContext (DbContextOptions<GamesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<GamesAPI.Model.Game> Game { get; set; } = default!;
    }
}
