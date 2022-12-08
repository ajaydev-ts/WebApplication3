using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Mark
    {
        public int Markid { get; set; }
        public int? Mark1 { get; set; }
        public int? Mark2 { get; set; }
        public int? id { get; set; }

        public virtual Student? IdNavigation { get; set; }
    }
}
