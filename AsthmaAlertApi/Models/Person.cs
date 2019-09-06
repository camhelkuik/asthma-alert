using System.Collections.Generic;
using JsonApiDotNetCore.Models;

namespace AsthmaAlertApi.Models
{
    public class Person : Identifiable
    {
        [Attr("first-name")]
        public string FirstName { get; set; }

        [Attr("last-name")]
        public string LastName { get; set; }

        [HasMany("tracking-items")]
        public virtual List<TrackingItem> TrackingItems { get; set; }
    }
}