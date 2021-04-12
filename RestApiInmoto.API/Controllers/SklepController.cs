using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestApiInmoto.DAL.Daos.Interfaces;
using RestApiInmoto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SklepController : CustomBaseController<SklepController, Sklep>
    {
        public SklepController(ILogger<SklepController> logger, IBaseDao<Sklep> baseDao) : base(logger, baseDao)
        {
        }
    }
}
