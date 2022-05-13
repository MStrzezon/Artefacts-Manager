using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Attribute
    {
        public int AttributeId { get; set; }

        public string Name { get; set; }

        public ICollection<ArtefactAttribute> ArtefactAttributes { get; set; }

        public ICollection<AttributeArtefactType> AttributeArtefactTypes { get; set; }
    }
}
