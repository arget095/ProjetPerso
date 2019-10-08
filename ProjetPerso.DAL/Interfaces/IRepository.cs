using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso.DAL.Interfaces
{
    public interface IRepository<TKey,TEntity>
        where TEntity : IEntity<TKey> /*condition pour que l'entity puisse etre utilise dans Irepository*/
    {
        /*CRUD ==> Create Read Update Delete*/

        TKey Create(TEntity entity); /*methode*/

        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();

        TEntity Update(TEntity entity);

        void Delete(TKey id);
    }
}
