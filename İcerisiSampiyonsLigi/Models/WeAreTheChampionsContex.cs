using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İcerisiSampiyonsLigi.Models
{
    public class WeAreTheChampionsContex : DbContext
    {
        public WeAreTheChampionsContex() : base("name=WeAreTheChampionsContex")
        {

        }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamColor> TeamColors { get; set; }
    }
}
