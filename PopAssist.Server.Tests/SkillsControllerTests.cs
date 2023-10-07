using NUnit.Framework;
using Moq;
using PdpAssist.Server.Controllers;
using PdpAssist.Shared;
using PdpAssist.Server.Repositories;
using System.Collections.Generic;

namespace PopAssist.Server.Tests
{
	public class Tests
	{
		MemoryRepository<Skill> _repository;
		[SetUp]

		public void Setup()
		{
			_repository = new MemoryRepository<Skill>();
			_repository.Add(new Skill { Name = "Test", CurrentScore = 5, DesirebleScore = 9 });
		}

		[Test]
		public void GetTest()
		{
			var controller = new SkillsController(_repository);
			var foo = controller.Get();
			Assert.IsNotNull(foo);
		}
	}
}