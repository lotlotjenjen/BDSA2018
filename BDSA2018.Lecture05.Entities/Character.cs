﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BDSA2018.Lecture05.Entities
{
    public partial class Character
    {
        public Character()
        {
            EpisodeCharacters = new HashSet<EpisodeCharacter>();
        }

        public int Id { get; set; }

        public int? ActorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Species { get; set; }

        [StringLength(50)]
        public string Planet { get; set; }

        public Actor Actor { get; set; }

        public ICollection<EpisodeCharacter> EpisodeCharacters { get; set; }
    }
}
