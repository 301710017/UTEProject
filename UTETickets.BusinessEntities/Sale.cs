using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Sale
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        DateTime Date { get; set; }

        [ForeignKey("Customer")]
        [Required]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Paypal")]
        [Required]
        public int TransactionID { get; set; }
        
        public Paypal Paypal { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
