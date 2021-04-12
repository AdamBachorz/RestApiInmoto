using RestApiInmoto.DAL.Config;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiInmoto.DAL.Daos
{
    public class SklepDao : BaseDao<Sklep>, ISklepDao
    {
        public SklepDao(ICustomConfig customConfig) : base(customConfig)
        {
        }
    }
}
