using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Models
{
    public class UserSubscriptionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [MaxLength(255)]
        [Required]
        public string Description { get; set; }
        [MaxLength(20)]
        public string RegistrationCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}