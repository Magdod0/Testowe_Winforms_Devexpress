using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowe_WinF_Dev.DataModels.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Get Data.
        /// </summary>
        /// <returns></returns>
        ObservableCollection<TEntity> GetAll();
        /// <summary>
        /// Get Item.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get(object id);
        /// <summary>
        /// Create Item.
        /// </summary>
        /// <param name="item"></param>
        void Create(TEntity item);
        /// <summary>
        /// Update Item.
        /// </summary>
        /// <param name="item"></param>
        void Update(TEntity item);
        /// <summary>
        /// Delete Item.
        /// </summary>
        /// <param name="id"></param>
        void Delete(TEntity item);
        ObservableCollection<TEntity> GetWhere(Func<TEntity, bool> predicate);
    }
}
