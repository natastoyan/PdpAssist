using PdpAssist.Server.Repositories;
using PdpAssist.Shared;

namespace PdpAssist.Server
{
	public static class SampleData
	{
		public static void AddSkillsRepository(this IServiceCollection services)
		{
			var skillRepository = new MemoryRepository<Skill>();

			skillRepository.Add(new Skill { Name = "Blazor", Priority = SkillPriority.Neutral, CurrentScore = 5, DesirebleScore = 10, TimeToImprove = 24 });
			skillRepository.Add(new Skill { Name = "LINQ", Priority = SkillPriority.High, CurrentScore = 7, DesirebleScore = 10, TimeToImprove = 16 });
			skillRepository.Add(new Skill { Name = "Patterns", Priority = SkillPriority.High, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 30 });
			skillRepository.Add(new Skill { Name = "async/await", Priority = SkillPriority.Critical, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 40 });
			skillRepository.Add(new Skill { Name = "JavaScript, React", Priority = SkillPriority.Low, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 40 });
			skillRepository.Add(new Skill { Name = "Moq", Priority = SkillPriority.Critical, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 20 });


			services.AddSingleton<IRepository<Skill>>(skillRepository);

		}

		public static void AddSkillGroupsRepository(this IServiceCollection services)
		{
			var skillGroupRepository = new MemoryRepository<SkillGroup>();

			skillGroupRepository.Add(new SkillGroup { Name = "Coding" });
			skillGroupRepository.Add(new SkillGroup { Name = "Testing" });
			skillGroupRepository.Add(new SkillGroup { Name = "Data bases" });
			skillGroupRepository.Add(new SkillGroup { Name = "Architecture" });

			services.AddSingleton<IRepository<SkillGroup>>(skillGroupRepository);

		}
	}
}
