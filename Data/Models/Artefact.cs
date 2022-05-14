using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Artefact
    {
        public int ArtefactId { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public ArtefactType ArtefactType { get; set; }

        public Category Category { get; set; }

        public ICollection<ArtefactAttribute> ArtefactAttributes { get; set; }
    }
}
