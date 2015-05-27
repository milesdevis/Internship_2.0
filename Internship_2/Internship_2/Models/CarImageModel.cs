using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Internship_2.Models
{
    public class CarImageModel : List<CarImage>
    {
        public List<string> PathOfImages;
        public int Length; 
           
         public CarImageModel()
        {
            
           string directoryOfImage = HttpContext.Current.Server.MapPath("~/Images/");
            XDocument imageData = XDocument.Load(directoryOfImage + @"/ImageMetaData.xml");

            var images = from image in imageData.Descendants("image") select new CarImage(image.Element("filename").Value, image.Element("description").Value);
            this.AddRange(images.ToList<CarImage>());
            
            var temp = from image in imageData.Descendants("image") select image.Element("filename").Value;
            this.PathOfImages.Add(directoryOfImage + temp);

            Length = this.Count;
            PathOfImages.ToArray();
       
        }



    }
}