﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NewsSite.Domain.Concrete;
using System;

namespace NewsSite.Domain.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180516132257_AddPostInClassComment")]
    partial class AddPostInClassComment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsSite.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ParentId");

                    b.Property<int?>("PostId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("DateChanged");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Rating");

                    b.Property<string>("Text");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.PostTag", b =>
                {
                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.Comment", b =>
                {
                    b.HasOne("NewsSite.Domain.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.Post", b =>
                {
                    b.HasOne("NewsSite.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("NewsSite.Domain.Entities.PostTag", b =>
                {
                    b.HasOne("NewsSite.Domain.Entities.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NewsSite.Domain.Entities.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
