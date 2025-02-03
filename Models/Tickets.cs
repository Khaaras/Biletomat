using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Tickets
    {
        [Key]
        public int Id { get; set; }
        public int TicketNumber { get; set; }           

        public bool IsSold { get; set; }

        [ForeignKey("Match")]
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual Users User { get; set; }

        public string FullName { get; set; } 

    }
}
