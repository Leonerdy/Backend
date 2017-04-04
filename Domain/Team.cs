using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Team
    {
        [Key]

        public int TeamId { get; set; }

        [Required(ErrorMessage = "The Field {0} is required")]
        [MaxLength(50, ErrorMessage = "The max lenght for field {0} is {1} characters")]
        [Index("Team_Name_LeagueId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Time")]
        public string Name { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required(ErrorMessage = "The Field {0} is required")]
        [StringLength(3, ErrorMessage = "The lenght for field {0} must be {1} characters", MinimumLength = 3)]
        [Index("Team_Initials_LeagueId_Index", IsUnique = true, Order = 1)]
        public string Initials { get; set; }

        [Index("Team_Name_LeagueId_Index", IsUnique = true, Order = 2)]
        [Index("Team_Initials_LeagueId_Index", IsUnique = true, Order = 2)]
        [Display(Name = "Ligas")]
        public int LeagueId { get; set; }

        public virtual League League { get; set; }
    }
}
