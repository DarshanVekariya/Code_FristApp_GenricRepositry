using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Location
{
    public class CityTbl
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        public string? CityName { get; set; }
        [ForeignKey("StateId")]
        public virtual int fkStateId { get; set; }

        public virtual StateTbl? State { get; set; }
    }
}
