using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Internship_2.Models
{
    public class BuyViewModel
    {
        public int SelectedID { set; get; }
        
        [DisplayName("Locations")]
        public IEnumerable<SelectListItem> _locations{ set; get;}
        
        [DisplayName("Make")]
        public IEnumerable<SelectListItem> _makes { set; get; }
        
        [DisplayName("BodyType")]
        public IEnumerable<SelectListItem> _bodytypes { set; get; }

        [DisplayName("Model")]
        public IEnumerable<SelectListItem> _models { set; get; }

     } 
}