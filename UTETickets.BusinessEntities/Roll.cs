using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Roll
    {
        [Key]
        [Required(ErrorMessage ="ID required")]
       public int Id { get; set; }

        [Required]
        public string Category { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}
