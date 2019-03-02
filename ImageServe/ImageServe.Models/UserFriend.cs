namespace ImageServe.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserFriend
    {
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public string FriendId { get; set; }
        public User Friend { get; set; }
    }
}
