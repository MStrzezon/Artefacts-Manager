using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class CategoryArtefact
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ArtefactId { get; set; }
        public Artefact Artefact { get; set; }
    }
}
