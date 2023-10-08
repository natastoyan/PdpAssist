using PdpAssist.Server.Repositories;
using PdpAssist.Shared;

namespace PdpAssist.Server
{
	public static class SampleData
	{
		public static void AddSkillsRepository(this IServiceCollection services)
		{
			var skillRepository = new MemoryRepository<Skill>();

			var codingGroup = new SkillGroup { Name = "Coding" };
			var testingGroup = new SkillGroup { Name = "Testing"};
			var frontGroup = new SkillGroup { Name = "Front-end" };
			var archGroup = new SkillGroup { Name = "Architecture" };
			skillRepository.Add(new Skill { Name = "Blazor", Group = frontGroup, Priority = SkillPriority.Neutral, CurrentScore = 5, DesirebleScore = 10, TimeToImprove = 24 });
			skillRepository.Add(new Skill { Name = "LINQ", Group = codingGroup, Priority = SkillPriority.High, CurrentScore = 7, DesirebleScore = 10, TimeToImprove = 16 });
			skillRepository.Add(new Skill { Name = "Patterns", Group = archGroup, Priority = SkillPriority.High, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 30 });
			skillRepository.Add(new Skill { Name = "async/await", Group = codingGroup, Priority = SkillPriority.Critical, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 40 });
			skillRepository.Add(new Skill { Name = "JavaScript, React", Group = frontGroup, Priority = SkillPriority.Low, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 40 });
			skillRepository.Add(new Skill { Name = "Moq", Group = testingGroup, Priority = SkillPriority.Critical, CurrentScore = 4, DesirebleScore = 10, TimeToImprove = 20 });


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
