using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingApp.Models
{
    public class JobContact
    {
        [Key]
        public int JobContactId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        [Required]
        public int JobId { get; set; }
        public Job Job {get; set;}
    }
}
