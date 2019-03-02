using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImageServe.Models
{
    public class ImageTag
    {
        [Required]
        public int ImageId { get; set; }
        public Image Image { get; set; }

        [Required]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
