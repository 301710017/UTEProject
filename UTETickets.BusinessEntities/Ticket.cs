using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Ticket
    {
        [Key]
        [Required]
        public int Id { get; set; }
       
        [Required(ErrorMessage ="Service required")]
        string Service { get; set; }

        [ForeignKey("Sale")]
        [Required]
       public int SaleID { get; set; }
        public Sale Sale { get; set; }

        [ForeignKey("Route")]
        [Required]
        public int RouteID { get; set; }
        public Route Route { get; set; }

        

    }
}
