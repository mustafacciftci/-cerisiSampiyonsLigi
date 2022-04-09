using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İcerisiSampiyonsLigi.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string TeamName { get; set; }
        public int Point { get; set; }
        public string ResimFutbolcu { get; set; }
        public string Amblem { get; set; }

        public virtual ICollection<Player> Players { get; set; } = new HashSet<Player>();//nullable
        public virtual ICollection<TeamColor> TeamColors { get; set; } = new HashSet<TeamColor>();
        public virtual ICollection<Match> Matches { get; set; } = new HashSet<Match>();

        public string TeamColorList()
        {
            List<string> list = new List<string>();
            foreach (var item in TeamColors)
            {
                list.Add(item.TeamColorList);
            }
            return string.Join(", ", list);
        }

        public string TeamPlayerList()
        {
            List<string> list = new List<string>();
            foreach (var item in Players)
            {
                list.Add(item.PlayerinTeam);
            }
            return string.Join(", ", list);
        }

        public string ColorList => $"{TeamColorList()}";
        public string PlayerList => $"{TeamPlayerList()}";
        public override string ToString()
        {
            return TeamName;
        }
    }
}
