using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingApp.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public bool RecruitingCompany { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
