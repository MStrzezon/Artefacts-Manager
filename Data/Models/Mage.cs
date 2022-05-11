using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Mage
    {
        public int MageId { get; set; }

        public string Name { get; set; }

        public int PowerLevel { get; set; }

        public int QuarterId { get; set; }
    }
}
