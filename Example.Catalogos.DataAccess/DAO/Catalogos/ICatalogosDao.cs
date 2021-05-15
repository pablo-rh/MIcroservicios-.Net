// <summary>
// <copyright file="ICatalogosDao.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.DataAccess.DAO.Catalogos
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Example.Catalogos.Entities.Model;

    /// <summary>
    /// Interface IUserDao
    /// </summary>
    public interface  ICatalogosDao
    {
        /// <summary>
        /// Method for get all users from db.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<CatalogosModel>> GetAllCatalogosAsync();

        /// <summary>
        /// Method for get user by id from db.
        /// </summary>
        /// <param name="id">Catalogos Id.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<CatalogosModel> GetCatalogosAsync(int id);

        /// <summary>
        /// Method for add Catalogos to DB.
        /// </summary>
        /// <param name="model">Catalogos Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> InsertCatalogos(CatalogosModel model);

        /// <summary>
        /// Method for update list.
        /// </summary>
        /// <param name="model">Catalogos Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> ActualizarDatos(CatalogosModel catalogosModel);

        /// <summary>
        /// Method for delete user.
        /// </summary>
        /// <param name="model">Catalogos Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> BorrarRegistro(int id);
    }
}
