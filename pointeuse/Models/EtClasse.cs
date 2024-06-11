using System.ComponentModel.DataAnnotations.Schema;

namespace pointeuse.Models
{
    public class EtClasse
    {
        public int Id { get; set; }

        [ForeignKey("Id")]
        public Groupe Groupe { get; set; }

        [ForeignKey("Id")]
        public Cycle Cycle { get; set; }
    }
}
