using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JsonApiDotNetCore.Models;
using Microsoft.AspNetCore.Identity;

namespace AsthmaAlertApi.Models
{
    public class Person : Identifiable
    {
        [Attr("first-name")]
        public string FirstName { get; set; }

        [Attr("last-name")]
        public string LastName { get; set; }
    }
}