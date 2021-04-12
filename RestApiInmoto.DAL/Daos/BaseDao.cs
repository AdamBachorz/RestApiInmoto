using RestApiInmoto.DAL.Config;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiInmoto.DAL.Daos
{
    public abstract class BaseDao<E> : IBaseDao<E> where E : Entity
    {
        protected ICustomConfig _customConfig;

        protected BaseDao(ICustomConfig customConfig)
        {
            _customConfig = customConfig;
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<E> GetAll()
        {
            return Invoke(db => db.Set<E>().ToList());
        }

        public IQueryable<E> GetAllLazy()
        {
            throw new NotImplementedException();
        }

        public E GetLatest()
        {
            throw new NotImplementedException();
        }

        public E GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public E Insert(E entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, E entity)
        {
            throw new NotImplementedException();
        }

        public void Update(E entity)
        {
            throw new NotImplementedException();
        }


        #region Invokers
        public R Invoke<R>(Func<ArvenaDbContext, R> func)
        {
            using (var arvenaDbContext = new ArvenaDbContext(_customConfig))
            {
                return func(arvenaDbContext);
            }
        }

        public void Invoke(Action<ArvenaDbContext> action)
        {
            using (var arvenaDbContext = new ArvenaDbContext(_customConfig))
            {
                action(arvenaDbContext);
            }
        } 
        #endregion

    }
}
