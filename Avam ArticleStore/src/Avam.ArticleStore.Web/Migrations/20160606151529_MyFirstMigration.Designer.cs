using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Avam.ArticleStore.Web.Domain.Data;

namespace Avam.ArticleStore.Web.Migrations
{
    [DbContext(typeof(ArticleContext))]
    [Migration("20160606151529_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901");

            modelBuilder.Entity("Avam.ArticleStore.Web.Domain.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BriefBody");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Source");

                    b.Property<int>("TagId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Avam.ArticleStore.Web.Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Avam.ArticleStore.Web.Domain.Article", b =>
                {
                    b.HasOne("Avam.ArticleStore.Web.Domain.Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
