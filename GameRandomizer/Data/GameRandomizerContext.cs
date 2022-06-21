using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameRandomizer.Models;

namespace GameRandomizer.Data
{
    public class GameRandomizerContext : DbContext
    {
        public GameRandomizerContext (DbContextOptions<GameRandomizerContext> options)
            : base(options)
        {
        }

        public DbSet<GameRandomizer.Models.Game>? Game { get; set; }
    }
}
