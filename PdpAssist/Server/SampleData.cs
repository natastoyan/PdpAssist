using PdpAssist.Server.Repositories;
using PdpAssist.Shared;

namespace PdpAssist.Server
{
	public static class SampleData
	{
		public static void AddSkillsRepository(this IServiceCollection services)
		{
			var skillRepository = new MemoryRepository<Skill>();

			skillRepository.Add(new Skill { Name = "Blazor", CurrentScore = 5, DesirebleScore = 10, TimeToImprove = TimeSpan.FromHours(24) });
			skillRepository.Add(new Skill { Name = "LINQ", CurrentScore = 7, DesirebleScore = 10, TimeToImprove = TimeSpan.FromHours(16) });
			skillRepository.Add(new Skill { Name = "Patterns", CurrentScore = 4, DesirebleScore = 10, TimeToImprove = TimeSpan.FromHours(24) });

			services.AddSingleton<IRepository<Skill>>(skillRepository);

		}
	}
}
