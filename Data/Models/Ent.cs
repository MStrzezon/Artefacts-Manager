using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Ent
    {
        public int EntId { get; set; }

        public string Name { get; set; }

        public int numberOfRings { get; set; }

        public int SpeciesId { get; set; }
    }
}
