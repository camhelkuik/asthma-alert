using AsthmaAlertApi.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AsthmaAlertApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class DailyAqController : JsonApiController<DailyAq>
    {
         public DailyAqController(
            IJsonApiContext jsonApiContext,
            IEntityRepository<DailyAq> entityRepository,
            ILoggerFactory loggerFactory) 
            : base(jsonApiContext, entityRepository, loggerFactory)
        { }
    }
}