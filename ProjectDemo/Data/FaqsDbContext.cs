using Microsoft.EntityFrameworkCore;
using ProjectDemo.Models;

namespace ProjectDemo.Data
{
	public class FaqsDbContext : DbContext
	{

		public FaqsDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Faq> Faqs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Topic> Topics { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Topic>().HasData(
				new Topic()
				{
					TopicId = "blz",
					Name = "Blazor"
				},
				new Topic()
				{
					TopicId = "asp",
					Name = "ASP.NET Core"
				},
				new Topic()
				{
					TopicId = "ef",
					Name="Entity Framework"
				}
				);

			modelBuilder.Entity<Category>().HasData(
				new Category()
				{
					CategoryId = "gen",
					Name = "General"
				},
				new Category()
				{
					CategoryId = "hist",
					Name = "History"
				}
				);

			modelBuilder.Entity<Faq>().HasData(
				new Faq()
				{
					FaqId = 1,
					Question= "What is Blazor?",
					Answer = "Blazor is a free and open-source web framework that enables developers to create web user interfaces based on components, using C# and HTML. It is being developed by Microsoft, as part of the ASP.NET Core web app framework.",
					CategoryId = "gen",
					TopicId = "blz"
				},
				new Faq()
				{
					FaqId = 2,
					Question = "When was blazor released?",
					Answer = "Blazor was released at 2018",
					CategoryId ="hist",
					TopicId = "blz"
				},
				new Faq()
				{
					FaqId = 3,
					Question = "What is ASP.NET Core?",
					Answer = "ASP.NET Core is an open-source modular web-application framework. It is a redesign of ASP.NET that unites the previously separate ASP.NET MVC and ASP.NET Web API into a single programming model. Despite being a new framework, built on a new web stack, it does have a high degree of concept compatibility with ASP.NET.",
					CategoryId = "gen",
					TopicId = "asp"
				},
				new Faq()
				{
					FaqId = 4,
					Question = "When was ASP.NET Core released?",
					Answer= "ASP.NET Core was released at June 7, 2016",
					CategoryId="hist",
					TopicId="asp"

				},
				new Faq()
				{
					FaqId = 5,
					Question ="What is EntityFrameWork Core?",
					Answer = "Entity Framework is an open source object–relational mapping framework for ADO.NET. It was originally shipped as an integral part of .NET Framework, however starting with Entity Framework version 6.0 it has been delivered separately from the .NET Framework.",
					CategoryId="gen",
					TopicId = "ef"
				},
				new Faq()
				{
					FaqId = 6,
					Question = "When was Entity Framework released?",
					Answer= "Entity Framework was released at 2008",
					CategoryId = "hist",
					TopicId = "ef"
				}
				);
		}

	}
}
