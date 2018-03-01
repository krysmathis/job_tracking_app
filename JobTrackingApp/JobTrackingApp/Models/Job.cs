using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTrackingApp.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateApplied { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public string Status { get; set; }

        // Notes or last action
        public string Notes { get; set; }

        public virtual ICollection<JobContact> JobContacts { get; set; }
        
    }
}