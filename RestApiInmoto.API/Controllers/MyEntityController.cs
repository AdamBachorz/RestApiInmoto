using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestApiInmoto.API.Classes;
using RestApiInmoto.API.Classes.Extensions;
using RestApiInmoto.API.Config;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApiInmoto.API.Controllers
{
    [Route("api/[controller]")]
    public class MyEntityController : CustomBaseController<MyEntityController, MyEntity>
    {
        private IMyEntityDao _myEntityDao;

        public MyEntityController(ILogger<MyEntityController> logger, IBaseDao<MyEntity> baseDao, IMyEntityDao myEntityDao) : base(logger, baseDao)
        {
            _myEntityDao = myEntityDao;
        }

        // GET: api/<controller>/special
        [HttpGet("special")]
        [BasicAuth]
        public MyEntity GetSpecial()
        {
            try
            {
                _logger.LogInformation("Pobieranie elementu specjalnego");
                var result = _myEntityDao.GetSpecial();
                _logger.LogIfNotFound(typeof(MyEntity), result);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw;
            }
        }
    }
}
