using ImageServe.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageServe.Models
{
    public class Tag : BaseModel<int>
    {
        public Tag()
        {
            Images = new List<ImageTag>();
        }

        public string Name { get; set; }

        public bool IsFromDescription { get; set; }

        public ICollection<ImageTag> Images { get; set; }
    }
}
