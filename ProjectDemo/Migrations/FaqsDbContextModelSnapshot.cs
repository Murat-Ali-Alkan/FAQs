﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectDemo.Data;

#nullable disable

namespace ProjectDemo.Migrations
{
    [DbContext(typeof(FaqsDbContext))]
    partial class FaqsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectDemo.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "gen",
                            Name = "General"
                        },
                        new
                        {
                            CategoryId = "hist",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("ProjectDemo.Models.Faq", b =>
                {
                    b.Property<int>("FaqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaqId"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FaqId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TopicId");

                    b.ToTable("Faqs");

                    b.HasData(
                        new
                        {
                            FaqId = 1,
                            Answer = "Blazor is a free and open-source web framework that enables developers to create web user interfaces based on components, using C# and HTML. It is being developed by Microsoft, as part of the ASP.NET Core web app framework.",
                            CategoryId = "gen",
                            Question = "What is Blazor?",
                            TopicId = "blz"
                        },
                        new
                        {
                            FaqId = 2,
                            Answer = "Blazor was released at 2018",
                            CategoryId = "hist",
                            Question = "When was blazor released?",
                            TopicId = "blz"
                        },
                        new
                        {
                            FaqId = 3,
                            Answer = "ASP.NET Core is an open-source modular web-application framework. It is a redesign of ASP.NET that unites the previously separate ASP.NET MVC and ASP.NET Web API into a single programming model. Despite being a new framework, built on a new web stack, it does have a high degree of concept compatibility with ASP.NET.",
                            CategoryId = "gen",
                            Question = "What is ASP.NET Core?",
                            TopicId = "asp"
                        },
                        new
                        {
                            FaqId = 4,
                            Answer = "ASP.NET Core was released at June 7, 2016",
                            CategoryId = "hist",
                            Question = "When was ASP.NET Core released?",
                            TopicId = "asp"
                        },
                        new
                        {
                            FaqId = 5,
                            Answer = "Entity Framework is an open source object–relational mapping framework for ADO.NET. It was originally shipped as an integral part of .NET Framework, however starting with Entity Framework version 6.0 it has been delivered separately from the .NET Framework.",
                            CategoryId = "gen",
                            Question = "What is EntityFrameWork Core?",
                            TopicId = "ef"
                        },
                        new
                        {
                            FaqId = 6,
                            Answer = "Entity Framework was released at 2008",
                            CategoryId = "hist",
                            Question = "When was Entity Framework released?",
                            TopicId = "ef"
                        });
                });

            modelBuilder.Entity("ProjectDemo.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "blz",
                            Name = "Blazor"
                        },
                        new
                        {
                            TopicId = "asp",
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            TopicId = "ef",
                            Name = "Entity Framework"
                        });
                });

            modelBuilder.Entity("ProjectDemo.Models.Faq", b =>
                {
                    b.HasOne("ProjectDemo.Models.Category", "Category")
                        .WithMany("Faqs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectDemo.Models.Topic", "Topic")
                        .WithMany("Faqs")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("ProjectDemo.Models.Category", b =>
                {
                    b.Navigation("Faqs");
                });

            modelBuilder.Entity("ProjectDemo.Models.Topic", b =>
                {
                    b.Navigation("Faqs");
                });
#pragma warning restore 612, 618
        }
    }
}
