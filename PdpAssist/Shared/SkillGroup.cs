using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpAssist.Shared
{
	public class SkillGroup
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public SkillGroup()
		{
			Id = Guid.NewGuid();
		}
	}
}
