using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTETickets.BusinessEntities
{
    public class Paypal
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
