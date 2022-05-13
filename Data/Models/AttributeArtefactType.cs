using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class AttributeArtefactType
    {
        public int ArtefactTypeId { get; set; }
        public ArtefactType ArtefactType { get; set; }

        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }
    }
}
