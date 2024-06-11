using System.ComponentModel.DataAnnotations.Schema;

namespace pointeuse.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom{ get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        [ForeignKey("Id")]
        public EtClasse EtClasse { get; set; }

    }
}
