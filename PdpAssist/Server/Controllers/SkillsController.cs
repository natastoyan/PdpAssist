using Microsoft.AspNetCore.Mvc;
using PdpAssist.Server.Repositories;
using PdpAssist.Shared;

namespace PdpAssist.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SkillsController : Controller
	{
		private readonly IRepository<Skill> _skillRepository;

		public SkillsController(IRepository<Skill> skillRepository)
		{
			_skillRepository = skillRepository;	
		}

		[HttpGet]
		public IEnumerable<Skill> Get()
		{
			return _skillRepository.GetAll();
		}

		[HttpPost]
		public void Post(Skill skill)
		{
			_skillRepository.Add(skill);
		}

		[HttpDelete("{id?}")]
		public void Delete(Guid id)
		{
			var entity = _skillRepository.GetAll().Single(_ => _.Id == id);
			_skillRepository.Remove(entity);
		}
	}
}
