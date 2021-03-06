﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BDSA2018.Lecture05.Entities
{
    public partial class Actor
    {
        public Actor()
        {
            Characters = new HashSet<Character>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}
