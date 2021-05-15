// <summary>
// <copyright file="CatalogosController.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Example.Catalogos.Dtos.Catalogos;
    using Example.Catalogos.Facade.Catalogos;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class Catalogos Controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ICatalogosFacade logicFacade;

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogosController"/> class.
        /// </summary>
        /// <param name="logicFacade">Catalogos Facade.</param>
        public CatalogosController(ICatalogosFacade logicFacade)
        {
            this.logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        /// <summary>
        /// Method to get all Catalogos.
        /// </summary>
        /// <returns>List of Catalogos.</returns>
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this.logicFacade.GetListCatalogosActive();
            return this.Ok(response);
        }

        /// <summary>
        /// Method to get Catalogos By Id.
        /// </summary>
        /// <param name="CatalogosId">Catalogos Id.</param>
        /// <returns>Catalogos Model.</returns>
        [Route("{CatalogosId}")]
        [HttpGet]
        public async Task<IActionResult> Get(int CatalogosId)
        {
            CatalogosDto response = null;

            response = await this.logicFacade.GetListCatalogosActive(CatalogosId);

            return this.Ok(response);
        }

        /// <summary>
        /// Method to Add Catalogos.
        /// </summary>
        /// <param name="dataToStore">Catalogos Model.</param>
        /// <returns>Success or exception.</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CatalogosDto dataToStore)
        {
            var response = await this.logicFacade.InsertCatalogos(dataToStore);
            return this.Ok(response);
        }

        /// <summary>
        /// Method to Add Catalogos.
        /// </summary>
        /// <param name="dataUpdate">Catalogos Model.</param>
        /// <returns>Success or exception.</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CatalogosDto dataUpdate)
        {
            var response = await this.logicFacade.ActualizarDatos(dataUpdate);
            return this.Ok(response);
        }

        /// <summary>
        /// Method to Add Catalogos.
        /// </summary>
        /// <param name="deleteId">Catalogos Model.</param>
        /// <returns>Success or exception.</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int deleteId)
        {
            var response = await this.logicFacade.BorrarRegistro(deleteId);
            return this.Ok(response);
        }

        /// <summary>
        /// Method Ping.
        /// </summary>
        /// <returns>Pong.</returns>
        [Route("/ping")]
        [HttpGet]
        public IActionResult Ping()
        {
            return this.Ok("Pong");
        }
    }
}