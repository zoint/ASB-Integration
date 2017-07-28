using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASB_Integration.Models
{
    public class Member
    {
        public int Id { get; set; }
        public int HBID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public BenefitPlan BenefitPlan { get; set; }
    }
}