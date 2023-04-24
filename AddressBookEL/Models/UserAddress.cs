using AddressBookEL.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookEL.Models
{
    public class UserAddress:BaseNumeric
    {
        [Required]
        [StringLength(50,MinimumLength =2)]
        public string Tittle { get; set; } // İş adresim başlık

        [Required]
        [StringLength(100, MinimumLength =10)]
        
        public string Details { get; set; } // Adres detayı

        public string UserId { get; set; } //FK

        public int NeighbourhoodId { get; set; } // FK
        public bool IsDefaultAddress { get; set; }

        [ForeignKey("NeighbourhoodId")]
        public virtual Neighbourhood NeighbourhoodFK { get; set; }
        [ForeignKey("UserId")]

        public virtual AppUser AppUser { get; set; }
    }
}
