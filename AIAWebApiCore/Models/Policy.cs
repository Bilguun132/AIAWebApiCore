using System;
using System.Collections.Generic;

namespace AIAWebApiCore.Models
{
    public partial class Policy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Benefits { get; set; }
        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
