using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class CategoryCharacter
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
