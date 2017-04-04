﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class League
    {
        [Key]

        public int LeagueId { get; set; }

        [Required(ErrorMessage ="The Field {0} is required")]
        [MaxLength(50, ErrorMessage ="The max lenght for field {0} is {1} characters")]
        [Index("League_Name_Index", IsUnique = true)]
        [Display(Name="Ligas")]
        public string Name { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
