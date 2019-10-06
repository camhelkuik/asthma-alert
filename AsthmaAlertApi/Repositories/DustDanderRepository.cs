  
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
    public class DustDanderRepository : DefaultEntityRepository<DustDander>
    {
        private readonly ILogger _logger;
        private readonly AppDbContext _context;
        private readonly IAuthenticationService _authenticationService;

        public DustDanderRepository(AppDbContext context,
            ILoggerFactory loggerFactory,
            IJsonApiContext jsonApiContext,
            IAuthenticationService authenticationService)
        : base(context, loggerFactory, jsonApiContext)
        { 
            _context = context;
            _logger = loggerFactory.CreateLogger<DustDanderRepository>();
            _authenticationService = authenticationService;
        }

        public override IQueryable<DustDander> Get()
        {
            return base.Get().Where(e => e.Date == System.DateTime.Today.ToString("d"));
        }

        public override async Task<DustDander> CreateAsync(DustDander dustDander)
        {
            return await base.CreateAsync(dustDander);
        }
    }
}