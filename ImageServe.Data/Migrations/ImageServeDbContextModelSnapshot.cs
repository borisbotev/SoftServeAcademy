﻿// <auto-generated />
using System;
using ImageServe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImageServe.Data.Migrations
{
    [DbContext(typeof(ImageServeDbContext))]
    partial class ImageServeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImageServe.Models.Friendship", b =>
                {
                    b.Property<string>("FriendId");

                    b.Property<string>("UserId");

                    b.HasKey("FriendId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("ImageServe.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUploaded")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ImageServe.Models.ImageLike", b =>
                {
                    b.Property<int>("ImageID");

                    b.Property<string>("UserId");

                    b.HasKey("ImageID", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ImageServe.Models.ImageTag", b =>
                {
                    b.Property<string>("Name");

                    b.Property<int>("ImageID");

                    b.Property<bool>("FromDescription");

                    b.HasKey("Name", "ImageID");

                    b.HasIndex("ImageID");

                    b.ToTable("ImageTags");
                });

            modelBuilder.Entity("ImageServe.Models.MainComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("ImageId");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("MainComments");
                });

            modelBuilder.Entity("ImageServe.Models.SubComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("MainCommentId");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MainCommentId");

                    b.ToTable("SubComments");
                });

            modelBuilder.Entity("ImageServe.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Details");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ImageServe.Models.Friendship", b =>
                {
                    b.HasOne("ImageServe.Models.User", "Friend")
                        .WithMany("FriendUsers")
                        .HasForeignKey("FriendId");

                    b.HasOne("ImageServe.Models.User", "User")
                        .WithMany("UserFriends")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ImageServe.Models.Image", b =>
                {
                    b.HasOne("ImageServe.Models.User", "User")
                        .WithMany("Images")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ImageServe.Models.ImageLike", b =>
                {
                    b.HasOne("ImageServe.Models.Image", "Image")
                        .WithMany("Likes")
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ImageServe.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ImageServe.Models.ImageTag", b =>
                {
                    b.HasOne("ImageServe.Models.Image", "Image")
                        .WithMany("Tags")
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ImageServe.Models.MainComment", b =>
                {
                    b.HasOne("ImageServe.Models.Image", "Image")
                        .WithMany("MainComments")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ImageServe.Models.SubComment", b =>
                {
                    b.HasOne("ImageServe.Models.MainComment", "MainComment")
                        .WithMany("SubComments")
                        .HasForeignKey("MainCommentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
