using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İcerisiSampiyonsLigi.Models
{
    public class TeamColor
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int? ColorId { get; set; }
        public virtual Color Color { get; set; }
        public virtual Team Team { get; set; }

        public string TeamColorList => $"{TeamColorNames()}";
        public string TeamColorNames()
        {

            if (ColorId == null)
            {
                return string.Empty;
            }
            return Color.ColorName;
        }
        public string TeamName => $"{TeamNameGetter()}";

        public string TeamNameGetter()
        {
            if (Team == null)
                return string.Empty;
            else
                return Team.TeamName;
        }

    }
}
