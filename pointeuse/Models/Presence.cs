using System.ComponentModel.DataAnnotations.Schema;

namespace pointeuse.Models
{
    public class Presence
    {
        public int Id { get; set; }
        public DateTime DateMatin { get; set; }
        public DateTime DateSoir { get; set; }

        [ForeignKey("Id")]
        public EtClasse EtClasse { get; set; }
    }
}
