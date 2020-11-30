using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeApp.Data_Access.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        /// <summary>
        /// Метод для получения информации о всех сущностях данного типа
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Метод получения информации о сущности по ее Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(Guid id);
        /// <summary>
        /// Метод добавления сущности в базу данных
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);
        /// <summary>
        /// Метод изменения сущности
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// Метод удаления сущности
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
        public void AddDefault(T entity, Guid id);
    }
}
