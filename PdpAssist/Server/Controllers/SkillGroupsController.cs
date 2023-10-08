using Microsoft.AspNetCore.Mvc;
using PdpAssist.Server.Repositories;
using PdpAssist.Shared;

namespace PdpAssist.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SkillGroupsController : Controller
	{
		private readonly IRepository<SkillGroup> _skillGroupRepository;

		public SkillGroupsController(IRepository<SkillGroup> skillGroupRepository)
		{
			_skillGroupRepository = skillGroupRepository;
		}

		[HttpGet]
		public IEnumerable<SkillGroup> Get()
		{
			return _skillGroupRepository.GetAll();
		}

		[HttpPost]
		public void Post(SkillGroup group)
		{
			_skillGroupRepository.Add(group);
		}

		[HttpDelete("{id?}")]
		public void Delete(Guid id)
		{
			var entity = _skillGroupRepository.GetAll().Single(_ => _.Id == id);
			_skillGroupRepository.Remove(entity);
		}
	}
}
