using Memberdhips_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Models
{
    public class UserSubscriptionViewModel
    {
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<UserSubscriptionModel> UserSubscriptions { get; set; }
        public bool DisableDropdown { get; set; }
        public string UserId { get; set; }
        public int SubscriptionId { get; set; }
    }
}