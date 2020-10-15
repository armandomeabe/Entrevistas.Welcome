namespace PrevencionSalud.Welcome.BLL.Users
{
    using PrevencionSalud.Welcome.Contract;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Representa una interface para la manipulación de usuarios
    /// </summary>
    public interface IUSerService
    {
        /// <summary>
        /// Búsqueda de usuarios
        /// </summary>
        /// <param name="queryString">Texto de búsqueda</param>
        /// <returns></returns>
        IList<UserContract> Search(string queryString);

        /// <summary>
        /// Obtener un usuario.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserContract Get(Guid id);

        /// <summary>
        /// Creación de un usuario
        /// </summary>
        /// <param name="contract"></param>
        void Create(UserContract contract);

        /// <summary>
        /// Actualización de un usuario
        /// </summary>
        /// <param name="contract"></param>
        void Update(UserContract contract);

        /// <summary>
        /// Baja lógica de un usuario
        /// </summary>
        /// <param name="contract"></param>
        void Delete(UserContract contract);

    }
}
