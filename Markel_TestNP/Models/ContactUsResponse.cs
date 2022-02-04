using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Markel_TestNP.Models
{
    public partial class ContactUsResponse
    {
        public int ResponseId { get; set; }
        public DateTime ResponseDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? AnsweredDate { get; set; }
    }
}
