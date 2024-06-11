using ApiPointeur.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc3ilpointeuse.Models
{
    public class updateleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        [ForeignKey("ElClasse")]
        public int ElClasseId { get; set; }
        public ElClasse ElClasse { get; set; }

    }
}
