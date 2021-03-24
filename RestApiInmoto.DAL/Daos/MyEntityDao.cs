using NHibernate.Criterion;
using RestApiInmoto.DAL.Config;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.DAL.Daos
{
    public class MyEntityDao : BaseDao<MyEntity>, IMyEntityDao
    {
        public MyEntityDao(INHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }

        public MyEntity GetSpecial()
        {
            return Invoke(session => 
                session.CreateCriteria(typeof(MyEntity))
                .Add(Restrictions.Eq("Text", "specjalny"))
                .UniqueResult<MyEntity>()
            );
        }
    }
}
