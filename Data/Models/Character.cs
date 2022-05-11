using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Character
    {
        public int CharacterId { get; set; }

        public string Name { get; set; }

        public ICollection<CategoryCharacter> Categories { get; set; }
    }
}
