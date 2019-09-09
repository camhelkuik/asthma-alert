  
using System.Linq;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using AsthmaAlertApi.Data;
using AsthmaAlertApi.Models;
using AsthmaAlertApi.Services;

namespace AsthmaAlertApi.Repositories
{
    public class TrackingItemRepository : DefaultEntityRepository<TrackingItem>
    {
        private readonly ILogger _logger;
        private readonly AppDbContext _context;
        private readonly IAuthenticationService _authenticationService;

        public TrackingItemRepository(AppDbContext context,
            ILoggerFactory loggerFactory,
            IJsonApiContext jsonApiContext,
            IAuthenticationService authenticationService)
        : base(context, loggerFactory, jsonApiContext)
        { 
            _context = context;
            _logger = loggerFactory.CreateLogger<TrackingItemRepository>();
            _authenticationService = authenticationService;
        }

        public override IQueryable<TrackingItem> Get()
        {
            return base.Get().Where(e => e.OwnerId == _authenticationService.GetUserId());
        }
    }
}