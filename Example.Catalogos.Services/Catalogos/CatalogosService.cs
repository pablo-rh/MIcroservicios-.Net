// <summary>
// <copyright file="CatalogosService.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Services.Catalogos
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Example.Catalogos.DataAccess.DAO.Catalogos;
    using Example.Catalogos.Dtos.Catalogos;
    using Example.Catalogos.Entities.Model;

    /// <summary>
    /// Class Catalogos Service.
    /// </summary>
    public class CatalogosService : ICatalogosService
    {
        private readonly IMapper mapper;

        private readonly ICatalogosDao modelDao;

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogosService"/> class.
        /// </summary>
        /// <param name="mapper">Object to mapper.</param>
        /// <param name="modelDao">Object to modelDao.</param>
        public CatalogosService(IMapper mapper, ICatalogosDao modelDao)
        {
            this.mapper = mapper;
            this.modelDao = modelDao ?? throw new ArgumentNullException(nameof(modelDao));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CatalogosDto>> GetAllCatalogosAsync()
        {
            return this.mapper.Map<List<CatalogosDto>>(await this.modelDao.GetAllCatalogosAsync());
        }

        /// <inheritdoc/>
        public async Task<CatalogosDto> GetCatalogosAsync(int id)
        {
            return this.mapper.Map<CatalogosDto>(await this.modelDao.GetCatalogosAsync(id));
        }

        /// <inheritdoc/>
        public async Task<bool> InsertCatalogos(CatalogosDto model)
        {
            return await this.modelDao.InsertCatalogos(this.mapper.Map<CatalogosModel>(model));
        }

        /// <inheritdoc/>
        public async Task<bool> ActualizarDatos(CatalogosDto model) {
            return await this.modelDao.ActualizarDatos(this.mapper.Map<CatalogosModel>(model));
        }

        /// <inheritdoc/>
        public async Task<bool> BorrarRegistro(int id) 
        {
            return await this.modelDao.BorrarRegistro(id);
        }

    }
}
