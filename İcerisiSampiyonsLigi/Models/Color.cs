using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İcerisiSampiyonsLigi.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public ICollection<TeamColor> TeamColors { get; set; } = new HashSet<TeamColor>();
    }
}
