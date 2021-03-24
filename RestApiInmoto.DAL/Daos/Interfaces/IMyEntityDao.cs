using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.DAL.Daos.Interfaces
{
    public interface IMyEntityDao : IBaseDao<MyEntity>
    {
        MyEntity GetSpecial();
    }
}
