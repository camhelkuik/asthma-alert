using JsonApiDotNetCore.Models;

namespace AsthmaAlertApi.Models
{
    public class TrackingItem : Identifiable<int>
    {
        [Attr("had-attack")]
        public int HadAttack { get; set; }

        [Attr("date")]
        public string Date { get; set; }

        //for example this would be like who I am trakcing, eg Linus
        [Attr("trakcing-title")]
        public string TrackingTitle { get; set; }

        public int OwnerId { get; set; }
        [HasOne("person")]
        public virtual Person Owner { get; set; }
    }
}