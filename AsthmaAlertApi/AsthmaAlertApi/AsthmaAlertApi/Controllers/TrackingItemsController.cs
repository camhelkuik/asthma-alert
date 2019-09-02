using AsthmaAlertApi.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AsthmaAlertApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class TrackingItemsController : JsonApiController<TrackingItem>
    {
         public TrackingItemsController(
            IJsonApiContext jsonApiContext,
            IEntityRepository<TrackingItem> entityRepository,
            ILoggerFactory loggerFactory) 
            : base(jsonApiContext, entityRepository, loggerFactory)
        { }
    }
}