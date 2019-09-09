using AspNet.Security.OAuth.Validation;
using AsthmaAlertApi.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace AsthmaAlertApi.Controllers
{
    [Authorize(AuthenticationSchemes = OAuthValidationDefaults.AuthenticationScheme)]

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