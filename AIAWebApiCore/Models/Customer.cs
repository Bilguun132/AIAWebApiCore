using System;
using System.Collections.Generic;

namespace AIAWebApiCore.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Policy = new HashSet<Policy>();
        }

        public int Id { get; set; }
        public int? AgentId { get; set; }
        public string Name { get; set; }
        public string PreferredName { get; set; }
        public string Title { get; set; }
        public string IcNumber { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string Anniversary { get; set; }
        public string FamilyOf { get; set; }
        public string Relationship { get; set; }
        public string Hobbies { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public string ReferredSource { get; set; }
        public string OtherSource { get; set; }
        public string LanguageSpoken { get; set; }
        public string Smoker { get; set; }
        public string Remark { get; set; }
        public string Handphone1 { get; set; }
        public string Handphone2 { get; set; }
        public string Pager { get; set; }
        public string FaxHome { get; set; }
        public string HomeTel1 { get; set; }
        public string HomeTel2 { get; set; }
        public string OfficeDid { get; set; }
        public string OfficeTel { get; set; }
        public string OfficeFax { get; set; }
        public string LastContact { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Website { get; set; }
        public string Address1 { get; set; }
        public double? PostalCode1 { get; set; }
        public string Country1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode2 { get; set; }
        public string Country2 { get; set; }
        public string BizAddress { get; set; }
        public string BizPostalCode { get; set; }
        public string BizCountry { get; set; }

        public Agent Agent { get; set; }
        public ICollection<Policy> Policy { get; set; }
    }
}
