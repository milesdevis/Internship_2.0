using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internship_2.Models
{
    public class CarImage
    {
          public CarImage(string path, string desc)
        {
            Path = path;
            Description = desc;
        }
        public string Path { get; set; }
        public string Description { get; set;}
    }
}