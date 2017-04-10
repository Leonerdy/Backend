using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class TournamentGroup
    {
        [Key]

        public int TournamentGroupId { get; set; }

        [Required(ErrorMessage = "The Field {0} is required")]
        [MaxLength(50, ErrorMessage = "The max lenght for field {0} is {1} characters")]
        [Index("TournamentGroup_Name_TournamentId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Grupo")]
        public string Name { get; set; }

        
        [Index("TournamentGroup_Name_TournamentId_Index", IsUnique = true, Order = 2)]
        [Display(Name = "Torneios")]
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }
}
}
