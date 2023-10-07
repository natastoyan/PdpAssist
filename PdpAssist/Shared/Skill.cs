using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpAssist.Shared
{
	public class Skill
	{
		public string Name { get; set; }
		public int CurrentScore { get; set; }
		public int DesirebleScore { get; set; }
		public IEnumerable<String> Resources { get; set; }
		public TimeSpan TimeToImprove { get; set; }
	}
}
