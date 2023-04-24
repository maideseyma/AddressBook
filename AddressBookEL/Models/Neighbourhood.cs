﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookEL.Models
{
    public class Neighbourhood:BaseNumeric
    {
        // eğer bu tablonun pksı string olsaydı basenumericten kalıtım alamazdı böyle bir senaryoda;
        // 1) basenonnumeric clası oluşturulabilir
        // 2) bu clas için direect olarak prop tanımlanabilir --> public string Id {get; set;}
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 5)]

        public string PostCode { get; set; }

        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public virtual District District { get; set; }
    }
}