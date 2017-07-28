using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASB_Integration.Models
{
    public class BenefitPlan
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int NetworkId { get; set; }
        public string Name { get; set; }
    }
}