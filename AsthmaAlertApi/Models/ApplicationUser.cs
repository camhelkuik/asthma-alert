using System.Collections.Generic;
using JsonApiDotNetCore.Models;
using Microsoft.AspNetCore.Identity;

namespace AsthmaAlertApi.Models
{
    public class ApplicationUser : IdentityUser, IIdentifiable<string>
    {
        object IIdentifiable.Id
        {
            get { return Id; }
            set { Id = value.ToString(); }
        }

        [Attr("first-name")]
        public string FirstName { get; set; }

        [Attr("last-name")]
        public string LastName { get; set; }

        [HasMany("tracking-items")]
        public virtual List<TrackingItem> TrackingItems { get; set; }
    }
}