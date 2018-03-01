using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTrackingApp.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(55, ErrorMessage = "Please enter a nickname")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(55, ErrorMessage = "Last name exceeds 55 characters")]
        public string LastName { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        // a contact is either associated with a company or a recruiter
        public int CompanyId { get; set; } = 0;
        public Company Company { get; set; }

        public bool IsRecruiter { get; set; }
        public string RecruitingCompanyName { get; set; }

        public string Email { get; set; }
        public string TwitterHandle { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<JobContact> JobContacts { get; set; }
    }
}