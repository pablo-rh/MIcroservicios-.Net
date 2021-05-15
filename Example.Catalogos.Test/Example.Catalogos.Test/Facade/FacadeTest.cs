// <summary>
// <copyright file="FacadeTest.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Test.Facade
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using System.Threading.Tasks;
    using Moq;
    using NUnit.Framework;
    using Example.Catalogos.Dtos.Catalogos;
    using Example.Catalogos.Facade.Catalogos;
    using Example.Catalogos.Services.Catalogos;

    /// <summary>
    /// Class CatalogosServiceTest.
    /// </summary>
    [TestFixture]
    public class FacadeTest : BaseTest
    {
        private CatalogosFacade modelFacade;

        /// <summary>
        /// The init.
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            var mockServices = new Mock<ICatalogosService>();
            var model = this.GetCatalogosDto();
            IEnumerable<CatalogosDto> listCatalogos = new List<CatalogosDto> { model };

            mockServices
                .Setup(m => m.GetAllCatalogosAsync())
                .Returns(Task.FromResult(listCatalogos));

            mockServices
                .Setup(m => m.GetCatalogosAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(model));

            mockServices
                .Setup(m => m.InsertCatalogos(It.IsAny<CatalogosDto>()))
                .Returns(Task.FromResult(true));

            this.modelFacade = new CatalogosFacade(mockServices.Object);
        }

        /// <summary>
        /// Test for selecting all models.
        /// </summary>
        /// <returns>nothing.</returns>
        [Test]
        public async Task GetAllCatalogosAsyncTest()
        {
            // arrange

            // Act
            var response = await this.modelFacade.GetListCatalogosActive();
            Console.Write(response);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Any());
        }

        /// <summary>
        /// gets the model.
        /// </summary>
        /// <returns>the model with the correct id.</returns>
        [Test]
        public async Task GetListCatalogosActive()
        {
            // arrange
            var id = 10;

            // Act
            var response = await this.modelFacade.GetListCatalogosActive(id);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(id, response.Id);
        }

        /// <summary>
        /// Test for inseting models.
        /// </summary>
        /// <returns>the bool if it was inserted.</returns>
        [Test]
        public async Task InsertCatalogos()
        {
            // Arrange
            var model = new CatalogosDto();

            // Act
            var response = await this.modelFacade.InsertCatalogos(model);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response);
        }
    }
}
