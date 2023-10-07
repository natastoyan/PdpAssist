using System.ComponentModel.DataAnnotations;
namespace PdpAssist.Web.Components
{
	public class SkillModel
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public int CurrentScore { get; set; }

		[Required]
		public int DesirebleScore { get; set; }

		public IEnumerable<String> Resources { get; set; }
	}
}
