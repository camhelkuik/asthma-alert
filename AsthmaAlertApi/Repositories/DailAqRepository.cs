  
using System.Linq;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using AsthmaAlertApi.Data;
using AsthmaAlertApi.Models;
using AsthmaAlertApi.Services;
using System.Threading.Tasks;

namespace AsthmaAlertApi.Repositories
{
    public class DailyAqRepository : DefaultEntityRepository<DailyAq>
    {
        private readonly ILogger _logger;
        private readonly AppDbContext _context;
        private readonly IAuthenticationService _authenticationService;

        public DailyAqRepository(AppDbContext context,
            ILoggerFactory loggerFactory,
            IJsonApiContext jsonApiContext,
            IAuthenticationService authenticationService)
        : base(context, loggerFactory, jsonApiContext)
        { 
            _context = context;
            _logger = loggerFactory.CreateLogger<DailyAqRepository>();
            _authenticationService = authenticationService;
        }

        // public override IQueryable<DailyAq> Get()
        // {
        //     return base.Get().Where(e => e.OwnerId == _authenticationService.GetUserId());
        // }

        // public override async Task<DailyAq> CreateAsync(DailyAq dailyAq)
        // {
        //     DailyAq.OwnerId = _authenticationService.GetUserId();
        //     return await base.CreateAsync(DailyAq);
        // }
    }
}