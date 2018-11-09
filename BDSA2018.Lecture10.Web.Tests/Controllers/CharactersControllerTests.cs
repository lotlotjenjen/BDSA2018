﻿using BDSA2018.Lecture10.Models;
using BDSA2018.Lecture10.Shared;
using BDSA2018.Lecture10.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MockQueryable.Moq;
using Moq;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BDSA2018.Lecture10.Web.Tests.Controllers
{
    public class CharactersControllerTests
    {
        [Fact]
        public async Task Get_given_existing_returns_dto()
        {
            var dto = new CharacterDTO();
            var repository = new Mock<ICharacterRepository>();
            repository.Setup(s => s.FindAsync(42)).ReturnsAsync(dto);
            var hub = new Mock<IHubContext<LogHub>>();
            var controller = new CharactersController(repository.Object, hub.Object);

            var get = await controller.Get(42);

            Assert.Equal(dto, get.Value);
        }

        [Fact]
        public async Task Get_given_non_existing_returns_NotFound()
        {
            var dto = new CharacterDTO();
            var repository = new Mock<ICharacterRepository>();
            var hub = new Mock<IHubContext<LogHub>>();
            var controller = new CharactersController(repository.Object, hub.Object);

            var get = await controller.Get(42);

            var result = get.Result;

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Get_returns_all_characters()
        {
            var dto = new CharacterDTO();
            var dtos = new[] { dto }.AsQueryable().BuildMock();
            var repository = new Mock<ICharacterRepository>();
            repository.Setup(s => s.Read()).Returns(dtos.Object);
            var hub = new Mock<IHubContext<LogHub>>();
            var controller = new CharactersController(repository.Object, hub.Object);

            var get = await controller.Get();

            Assert.Equal(dto, get.Value.Single());
        }
    }
}
