using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Location
{
    public class StateTbl
    {
        [Key]
        public int StateId { get; set; }
        [Required]
        public string? StateName { get; set; }
       // public string? CountryName { get; set; }
        [ForeignKey("CountryId")]
        public virtual int fkContryId{ get; set;}
        public virtual CountryTbl? Country { get; set; }

        public virtual List<CityTbl>? CityTbls { get; set; }

    }
}
