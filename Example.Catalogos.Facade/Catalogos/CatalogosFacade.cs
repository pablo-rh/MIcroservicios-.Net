// <summary>
// <copyright file="CatalogosFacade.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Facade.Catalogos
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Example.Catalogos.Dtos.Catalogos;
    using Example.Catalogos.Services.Catalogos;

    /// <summary>
    /// Class Catalogos Facade.
    /// </summary>
    public class CatalogosFacade : ICatalogosFacade
    {
        private readonly ICatalogosService modelService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogosFacade"/> class.
        /// </summary>
        /// <param name="modelService">Interface Catalogos Service.</param>
        public CatalogosFacade(ICatalogosService modelService)
        {
            this.modelService = modelService ?? throw new ArgumentNullException(nameof(modelService));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CatalogosDto>> GetListCatalogosActive()
        {
            return await this.modelService.GetAllCatalogosAsync();
        }

        /// <inheritdoc/>
        public async Task<CatalogosDto> GetListCatalogosActive(int id)
        {
            return await this.modelService.GetCatalogosAsync(id);
        }

        /// <inheritdoc/>
        public async Task<bool> InsertCatalogos(CatalogosDto model)
        {
            return await this.modelService.InsertCatalogos(model);
        }

        /// <inheritdoc/>
        public async Task<bool> ActualizarDatos(CatalogosDto model) {
            return await this.modelService.ActualizarDatos(model);
        }

        /// <inheritdoc/>
        public async Task<bool> BorrarRegistro(int id) {
            return await this.modelService.BorrarRegistro(id);
        }

    }
}
