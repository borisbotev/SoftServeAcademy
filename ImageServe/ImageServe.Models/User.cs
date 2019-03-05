namespace ImageServe.Models
{
    
    using System.Collections.Generic;
    using Common;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public User()
        {
            Images = new List<Image>();
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Details { get; set; }

        public string Avatar { get; set; }

        public List<Image> Images { get; set; }

    }
}
