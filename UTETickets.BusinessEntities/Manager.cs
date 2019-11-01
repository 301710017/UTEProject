using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Manager
    {
        [Key]
        [Required(ErrorMessage = "ID required")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name required")]
        [StringLength(30, ErrorMessage = "Error, maximum 30 characters")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "LastName required")]
        [StringLength(30, ErrorMessage = "Error, maximum 30 characters")]
        public string LastName { get; set; }
        
        [ForeignKey("Roll")]
        [Required(ErrorMessage ="Category required")]
        public int RollID { get; set; }
        public Roll Roll { get; set; }


        [Required(ErrorMessage = "Password required")]
        [StringLength(30, ErrorMessage = "Error, maximum 9 characters")]
        string Password { get; set; }
    }
}
