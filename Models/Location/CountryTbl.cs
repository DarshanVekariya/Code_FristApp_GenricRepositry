using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Location
{
    public class CountryTbl
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        public string? CountryName { get; set; }
       public virtual List<StateTbl>? StateTbls { get; set; }
    }
}
