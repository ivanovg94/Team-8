﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Team8Project.Contracts;
using Team8Project.Core;
using Team8Project.Core.Commands.CreateHero;
using Team8Project.Data;

namespace Team8Project.Tests.Commands
{
    [TestClass]
    public class CreateClericCommand_Should
    {
        [TestMethod]
        public void AddToList_WhenValidaInput()
        {
            var factoryMock = new Mock<IFactory>();
            var dataMock = new Mock<IDataContainer>();
            var hero = new Mock<IHero>();

            var predefinedList = new List<IHero>() { };

            dataMock
                .SetupGet(data => data.ListHeros)
                .Returns(predefinedList);

            var command = new CreateClericCommand(factoryMock.Object, dataMock.Object);

            command.Execute();

            Assert.IsTrue(dataMock.Object.ListHeros.Count >= 1);
        }
    }
}
