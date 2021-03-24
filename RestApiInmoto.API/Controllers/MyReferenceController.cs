using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestApiInmoto.API.Classes;
using RestApiInmoto.API.Classes.Extensions;
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
    [ApiController]
    public class MyReferenceController : CustomBaseController<MyReferenceController, MyReference>
    {
        private readonly IMyReferenceDao _myReferenceDao;

        public MyReferenceController(ILogger<MyReferenceController> logger, IBaseDao<MyReference> baseDao, IMyReferenceDao myReferenceDao) 
            : base(logger, baseDao)
        {
            _myReferenceDao = myReferenceDao;
        }
    }
}
