namespace ImageServe.Data
{
    using ImageServe.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ImageServeDbContext : IdentityDbContext<User>
    {
        public DbSet<Image> Images { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<ImageTag> ImageTags { get; set; }

        //public DbSet<User> Users { get; set; }

        public DbSet<UserFriend> UserFriends { get; set; }


        public ImageServeDbContext(DbContextOptions<ImageServeDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           

            //one to many relations
            builder.Entity<Image>()
                .HasOne(i => i.User)
                .WithMany(u => u.Images)
                .HasForeignKey(i => i.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<ImageTag>()
                .HasKey(it => new { it.TagId, it.ImageId });

            builder.Entity<ImageTag>()
                .HasOne(it => it.Image)
                .WithMany(i => i.Tags)
                .HasForeignKey(it => it.ImageId);

            builder.Entity<ImageTag>()
                .HasOne(it => it.Tag)
                .WithMany(t => t.Images)
                .HasForeignKey(it => it.TagId);
        }
    }
}
