using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class ArtefactType
    {
        public int ArtefactTypeId { get; set; }

        public string TypeName { get; set; }

        public ICollection<AttributeArtefactType> AttributeArtefactTypes { get; set; }
    }
}
