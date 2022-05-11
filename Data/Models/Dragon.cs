using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Dragon
    {
        public int DragonId { get; set; }

        public string Name { get; set; }

        public int WingSpan { get; set; }

        public int SpeciesId { get; set; }
    }
}
