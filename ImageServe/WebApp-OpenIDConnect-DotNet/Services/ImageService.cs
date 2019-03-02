using ImageServe.Data.Common;
using ImageServe.Models;
using ImageServe.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageServe.Web.Services
{
    public class ImageService : IImageService
    {

        private readonly IRepository<Image> _imageRepository;

        public ImageService(IRepository<Image> imageRepository)
        {
            _imageRepository = imageRepository;
        }


        public Task CommentAsync()
        {
            throw new NotImplementedException();
        }

        public Task EditAsync()
        {
            throw new NotImplementedException();
        }

        public Task LikeAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Image>> SearchAsync()
        {
            throw new NotImplementedException();
        }

        public Task UnlikeAsync()
        {
            throw new NotImplementedException();
        }

        public Task UploadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
