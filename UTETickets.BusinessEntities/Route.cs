using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Route
    {
        [Key]
        [Required]
       public  int Id { get; set; }

        [Required(ErrorMessage = "Route required")]
        [StringLength(30, ErrorMessage = "Error, maximum 30 characters")]
        public string route { get; set; }

        [Required(ErrorMessage = "Cost required")]
        public decimal Cost { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        
    }
}
