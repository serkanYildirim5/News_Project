using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News_Project.UI.Models
{
    public class WriterModel
    {
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public News News { get; set; }
        public string NewsTitle { get; set; }
        [AllowHtml]
        public string NewsContent { get; set; }
        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }
    }
}