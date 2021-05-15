// <summary>
// <copyright file="CatalogosServiceTest.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Test.Services.Catalogos
{
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Example.Catalogos.DataAccess.DAO.Catalogos;
    using Example.Catalogos.Entities.Context;
    using Example.Catalogos.Services.Mapping;
    using Example.Catalogos.Services.Catalogos;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    /// <summary>
    /// Class CatalogosServiceTest.
    /// </summary>
    [TestFixture]
    public class CatalogosServiceTest : BaseTest
    {
        private ICatalogosService modelServices;

        private IMapper mapper;

        private ICatalogosDao modelDao;

        private DatabaseContext context;

        /// <summary>
        /// Init configuration.
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            this.mapper = mapperConfiguration.CreateMapper();

            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Temporal")
                .Options;

            this.context = new DatabaseContext(options);
            this.context.CatCatalogos.AddRange(this.GetAllCatalogoss());
            this.context.SaveChanges();

            this.modelDao = new CatalogosDao(this.context);
            this.modelServices = new CatalogosService(this.mapper, this.modelDao);
        }

        /// <summary>
        /// Method to verify Get All Catalogoss.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task ValidateGetAllCatalogoss()
        {
            var result = await this.modelServices.GetAllCatalogosAsync();

            Assert.True(result != null);
            Assert.True(result.Any());
        }

        /// <summary>
        /// Method to validate get model by id.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task ValidateSpecificCatalogoss()
        {
            var result = await this.modelServices.GetCatalogosAsync(2);

            Assert.True(result != null);
            Assert.True(result.FirstName == "Jorge");
        }

        /// <summary>
        /// test the insert.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task InsertCatalogos()
        {
            // Arrange
            var model = this.GetCatalogosDto();

            // Act
            var result = await this.modelServices.InsertCatalogos(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }
    }
}
