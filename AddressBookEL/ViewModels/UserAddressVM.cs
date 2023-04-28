using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookEL.Models;
using AddressBookEL.IdentityModels;

namespace AddressBookEL.ViewModels
{
    public class UserAddressVM
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsRemoved { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]

        public string Tittle { get; set; } //İş adresim Başlık
        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage ="Adres detayı min 10 mak 100 karakter olmalıdır!")]
        public string Details { get; set; } //adres detayı
        public string UserId { get; set; }
        public int NeighbourhoodId { get; set; }
        public bool IsDefaultAddress { get; set; }

        public NeighbourhoodVM? NeighbourhoodFK { get; set; }

        public AppUser? AppUser { get; set; }

    }
}