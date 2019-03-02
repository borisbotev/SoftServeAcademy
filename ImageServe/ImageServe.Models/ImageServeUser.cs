using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageServe.Models
{
    public class ImageServeUser : IdentityUser
    {
        public ImageServeUser()
        {
            Images = new List<Image>();

        }

        public string Avatar { get; set; }

        public List<Image> Images { get; set; }

    }
}
