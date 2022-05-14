using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class ArtefactAttribute
    {
        public int ArtefactId { get; set; }
        public Artefact Artefact { get; set; }

        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }

        public string Value { get; set; }
    }
}
