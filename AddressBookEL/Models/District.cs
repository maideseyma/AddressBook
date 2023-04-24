using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookEL.Models
{
    [Table("Districts")]
    public class District:BaseNumeric
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")] // cityId ye yazdığım int değerinin city tablosunda karşılığı olmak zorunda
        public virtual City City { get; set; } 
        // CityId propertysi ForeginKey olacağı için burada city tablosuyla ilişklisi kuruldu. Dipnot: ilişkiler burada kurulacağı gibi mycontext clası içindeki onmodel creating metodu ezilerek (override) kurulabilir

    }
}
