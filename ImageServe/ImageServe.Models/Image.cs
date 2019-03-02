using ImageServe.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImageServe.Models
{
    public class Image : BaseModel<int>
    {
        public Image()
        {
            DateUploaded = DateTime.UtcNow;
            Tags = new List<ImageTag>();
        }

        [Required]
        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateUploaded { get; set; }

        public bool IsPublic { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<ImageTag> Tags { get; set; }
    }
}

        
