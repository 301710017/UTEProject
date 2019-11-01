using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage ="ID required")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name required")]
        [StringLength(30, ErrorMessage = "Error, maximum 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "LastName required")]
        [StringLength(30, ErrorMessage = "Error, maximum 30 characters")]
        public string LastName { get; set; }

        public virtual ICollection<Sale>Sales { get; set; }


    }
}
