using Microsoft.Extensions.DependencyInjection;
using RestApiInmoto.API.Config;
using RestApiInmoto.DAL.Config;
using RestApiInmoto.DAL.Daos;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.API.Config
{
    public static class DependencyInjection
    {
        public static void RegisterModules(IServiceCollection services)
        {
            services.AddScoped<INHibernateHelper, NHibernateHelper>();

            // DAOs
            services.AddScoped<IBaseDao<MyEntity>, MyEntityDao>();
            services.AddScoped<IMyEntityDao, MyEntityDao>();
            services.AddScoped<IBaseDao<MyReference>, MyReferenceDao>();
            services.AddScoped<IMyReferenceDao, MyReferenceDao>();

            //Services
            services.AddScoped<IUserService, UserService>();
        }
    }
}
