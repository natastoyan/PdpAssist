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
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void GetTest()
		{
			var repository = new MemoryRepository<Skill>();
			repository.Add(new Skill { Name = "Test", CurrentScore = 5, DesirebleScore = 9 });
			var controller = new SkillsController(repository);
			var foo = controller.Get();
			Assert.IsNotNull(foo);
		}
	}
}