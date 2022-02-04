using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Markel_TestNP.Models
{
    public partial class PageContent
    {
        public int PageId { get; set; }
        public string TemplateKey { get; set; }
        public string PageUrl { get; set; }
        public string MenuText { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public string ImageUrl { get; set; }
    }
}
