using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentManagement.Models.Domains
{
    public class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime AddedTime { get; set; }
    }
}
