using PdpAssist.Shared;
using System.ComponentModel.DataAnnotations;
namespace PdpAssist.Web.Components
{
	public class SkillModel
	{
		[Required]
		public string Name { get; set; }

		[Required]
		[Range(0, 10, ErrorMessage = "Score must be between 0 to 10")]
		public int CurrentScore { get; set; }

		[Required]
		[Range(0, 10, ErrorMessage = "Score must be between 0 to 10")]
		public int DesirebleScore { get; set; }

		[Required]
		public int TimeToImprove { get; set; }

		public SkillPriority Priority { get; set; }

		public IEnumerable<String> Resources { get; set; }

		public SkillGroup Group { get; set; }
	}
}
