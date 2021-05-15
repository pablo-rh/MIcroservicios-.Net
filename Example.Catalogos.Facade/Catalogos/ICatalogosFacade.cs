// <summary>
// <copyright file="ICatalogosFacade.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.Facade.Catalogos
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Example.Catalogos.Dtos.Catalogos;

    /// <summary>
    /// Interface User Facade.
    /// </summary>
    public interface ICatalogosFacade
    {
        /// <summary>
        /// Method for get all list of Users.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<CatalogosDto>> GetListCatalogosActive();

        /// <summary>
        /// Method for get User by id.
        /// </summary>
        /// <param name="id">Id User.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<CatalogosDto> GetListCatalogosActive(int id);

        /// <summary>
        /// Method to add user to DB.
        /// </summary>
        /// <param name="model">User Model.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> InsertCatalogos(CatalogosDto model);

        /// <summary>
        /// Method update user.
        /// </summary>
        /// <param name="model">User Model.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> ActualizarDatos(CatalogosDto dataToStore);

        /// <summary>
        /// Method delete user.
        /// </summary>
        /// <param name="model">User Model.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> BorrarRegistro(int id);
    }
}