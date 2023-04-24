using AddressBookEL.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBookEL.ViewModels
{
    public class UserAddressVM
    {
   
        public int Id { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public bool IsRemoved { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; } // İş adresim başlık

        [Required]
        [StringLength(100, MinimumLength = 10)]

        public string Details { get; set; } // Adres detayı

        public string UserId { get; set; }

        public int NeighbourhoodId { get; set; } // FK
        public bool IsDefaultAddress { get; set; }


        public NeighbourhoodVM NeighbourhoodFK { get; set; }

        public AppUser AppUser { get; set; }
    }
}
