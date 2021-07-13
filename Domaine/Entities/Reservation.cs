using Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourMe.Data.Entities.Enum;

namespace TourMe.Data.Entities
{
   public class Reservation
    {
        public string UtilisateurId { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }

        public DateTime DateReservation { get; set; }
        public int NbrReservation { get; set; }
 
        public decimal Tariff { get; set; }
        public CardType CardType { get; set; }
        [Display(Name = "Credit Card Number")]
        [Required(ErrorMessage = "required")]
        [Range(100000000000, 9999999999999999999, ErrorMessage = "must be between 12 and 19 digits")]
        public long NumeroCarte { get; set; }
        public DateTime ExpirationDate { get; set; }
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
        [StringLength(3, ErrorMessage = "The {0}  cannot exceed {1} characters. ")]
        public string CCV { get; set; }
        public int CodePostale { get; set; }

    }
}
