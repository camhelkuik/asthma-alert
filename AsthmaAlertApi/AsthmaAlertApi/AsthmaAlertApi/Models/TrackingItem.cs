using JsonApiDotNetCore.Models;

namespace AsthmaAlertApi.Models
{
    public class TrackingItem : Identifiable<int>
    {
        [Attr("had-attack")]
        public int HadAttack { get; set; }

        [Attr("date")]
        public string Date { get; set; }
        
        public int OwnerId { get; set; }
        [HasOne("person")]
        public virtual Person Owner { get; set; }
    }
}