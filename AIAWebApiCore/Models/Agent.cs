using System;
using System.Collections.Generic;

namespace AIAWebApiCore.Models
{
    public partial class Agent
    {
        public Agent()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AgentId { get; set; }
        public string Email { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
