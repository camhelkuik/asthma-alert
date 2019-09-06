using AsthmaAlertApi.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AsthmaAlertApi.Controllers
{
    [Route("api/v1/[controller]")]
    public class PeopleController : JsonApiController<Person>
    {
         public PeopleController(
            IJsonApiContext jsonApiContext,
            IEntityRepository<Person> entityRepository,
            ILoggerFactory loggerFactory) 
            : base(jsonApiContext, entityRepository, loggerFactory)
        { }
    }
}