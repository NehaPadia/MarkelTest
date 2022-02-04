using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Markel_TestNP.Models
{
    public partial class PageLink
    {
        public int PageId { get; set; }
        public int LinkedPageId { get; set; }
    }
}
