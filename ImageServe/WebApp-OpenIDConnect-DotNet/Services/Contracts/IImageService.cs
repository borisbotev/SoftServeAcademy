using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageServe.Models;

namespace ImageServe.Web.Services.Contracts
{
    public interface IImageService
    {
        Task UploadAsync();

        Task RemoveAsync();

        Task EditAsync();

        Task LikeAsync();

        Task UnlikeAsync();

        Task CommentAsync();

        Task<ICollection<Image>> SearchAsync();
    }
}
