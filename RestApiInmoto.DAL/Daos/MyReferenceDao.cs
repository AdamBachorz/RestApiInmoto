using RestApiInmoto.DAL.Config;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.DAL.Daos
{
    public class MyReferenceDao : BaseDao<MyReference>, IMyReferenceDao
    {
        public MyReferenceDao(INHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}
