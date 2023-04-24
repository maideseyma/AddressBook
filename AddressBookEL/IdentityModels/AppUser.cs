using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookEL.IdentityModels
{
    public class AppUser:IdentityUser
    {

        // IdentityUser classının içindeki propertylerden farklı eklemek istediğin özellikler var ise IdentityUser clasından kalıtım alarak tabluyu genişletebiliriz

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        public DateTime? Birtdate { get; set; }

        public bool IsPassive { get; set; }



        [Required]
        [StringLength(10, MinimumLength =10)]
        [RegularExpression("^[0-9]*", ErrorMessage = "Telefon rakamlardan oluşmalıdır")]
        public override string PhoneNumber { get; set; }

    }
}
