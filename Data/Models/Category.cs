﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public ICollection<CategoryCharacter> Characters { get; set; }
    }
}
