using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectDemo.Data;
using ProjectDemo.Models;
using System.Diagnostics;

namespace ProjectDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly FaqsDbContext _context;
        public HomeController(FaqsDbContext context) 
        {
            _context = context;
        }

		[Route("topic/{topic}/category/{category}")]
		[Route("topic/{topic}")]
		[Route("category/{category}")]
		[Route("/")]
        public IActionResult Index(string topic ,string category)
		{
			List<Faq> faqs = _context.Faqs.Include(f => f.Topic).Include(f => f.Category).OrderBy(f => f.Category.Name).ToList();
			ViewBag.Categories = _context.Categories.OrderBy(c => c.Name).ToList();
			ViewBag.Topics = _context.Topics.OrderBy(c => c.Name).ToList();

			if(!string.IsNullOrEmpty(category))
			{
				 faqs = faqs.Where(f => f.CategoryId == category).ToList();
			}

			if (!string.IsNullOrEmpty(topic))
			{
				faqs = faqs.Where(f => f.TopicId == topic).ToList();
			}


			return View(faqs);
		}

		
	}
}
