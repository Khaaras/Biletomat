using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    class Match
    {
        [Key]
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string GuestTeam { get; set; }
        public DateTime GameDate { get; set; }
        public string TypeOfEvent { get; set; }        
       
    }
}
