using System.ComponentModel.DataAnnotations.Schema;

namespace pointeuse.Models
{
    public class Emargement
    {
        public int Id { get; set; }
        public DateTime Datearivée { get; set; }

        [ForeignKey("Id")]
        public Etudiant Etudiant { get; set; }
       

    }
}
