using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDemo.Models
{
	public class Faq
	{
		public int FaqId { get; set; }
		public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;

		public string CategoryId { get; set; } = string.Empty;
        public Category Category { get; set; } = null!;

		public string TopicId { get; set; } = string.Empty;
        public Topic Topic { get; set; } = null!;

    }
}
