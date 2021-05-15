// <summary>
// <copyright file="ICatalogosService.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Services.Catalogos
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Example.Catalogos.Dtos.Catalogos;

    /// <summary>
    /// Interface Catalogos Service.
    /// </summary>
    public interface ICatalogosService
    {
        /// <summary>
        /// Method for get all users from db.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<CatalogosDto>> GetAllCatalogosAsync();

        /// <summary>
        /// Method for get Catalogos by id from db.
        /// </summary>
        /// <param name="id">User Id.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<CatalogosDto> GetCatalogosAsync(int id);

        /// <summary>
        /// Method for add Catalogos to DB.
        /// </summary>
        /// <param name="model">Catalogos Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> InsertCatalogos(CatalogosDto model);

        /// <summary>
        /// Method for update list.
        /// </summary>
        /// <param name="model">Catalogos Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> ActualizarDatos(CatalogosDto model);
        
        /// <summary>
        /// Method for Delete user.
        /// </summary>
        /// <param name="model">Catalogos Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> BorrarRegistro(int id);
    }
}
